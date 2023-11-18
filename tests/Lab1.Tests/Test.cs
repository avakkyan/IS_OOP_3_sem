using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Test
{
    private const double Money = 1000000;
    private const double FuelMoney = Money / 2;
    public static TheoryData<Ship, Result> TestRegularShipAndAugurShipData => new()
    {
        { new RegularShip(Money), new Result(Status.ShipIsDestroyed) },
        { new AugurShip(Money), new Result(Status.ShipIsLost) },
    };

    public static TheoryData<Ship, Result> TestVaklasShipWithAndWithoutPhotonDeflectorData => new()
    {
        { new VaklasShip(Money), new Result(Status.CrewIsDead) },
        { new VaklasShip(Money), new Result(Status.Success) },
    };

    public static TheoryData<Ship, Result> TestVaklasAugurMeridianData => new()
    {
        { new VaklasShip(Money), new Result(Status.Success) },
        { new AugurShip(Money), new Result(Status.Success) },
        { new MeridianShip(Money), new Result(Status.Success) },
    };

    [Theory]
    [MemberData(nameof(TestRegularShipAndAugurShipData))]
    public void TestRegularShipAndAugurShip(Ship ship, Result result)
    {
        var environment = new HighDensityEnvironment();
        environment.AddChannel(200);
        var route = new Route(new List<Section> { new(environment, 100) });
        var service = new ShipService();
        Assert.Equal(result.Status, service.PassRoute(route, ship).Status);
    }

    [Theory]
    [MemberData(nameof(TestVaklasShipWithAndWithoutPhotonDeflectorData))]
    public void TestVaklasShipWithAndWithoutPhotonDeflector(Ship ship, Result result)
    {
        if (result.Status == Status.Success)
        {
            ship.Deflector?.AddPhotonDeflector();
        }

        ship.BuyGravitonFuel(FuelMoney);
        ship.BuyPlasmaFuel(FuelMoney);

        var environment = new HighDensityEnvironment();
        environment.AddChannel(200);
        environment.AddObstacle(new Flash());
        var route = new Route(new List<Section> { new(environment) });
        var service = new ShipService();

        Assert.Equal(result.Status, service.PassRoute(route, ship).Status);
    }

    [Theory]
    [MemberData(nameof(TestVaklasAugurMeridianData))]
    public void TestVaklasAugurMeridian(Ship ship, Result result)
    {
        ship.BuyPlasmaFuel(FuelMoney);
        ship.BuyGravitonFuel(FuelMoney);

        var environment = new NitrideParticlesEnvironment();
        environment.AddObstacle(new CosmoWhale());
        var route = new Route(new List<Section> { new(environment, 100) });
        var service = new ShipService();
        Result actualResult = service.PassRoute(route, ship);
        Assert.Equal(result.Status, actualResult.Status);
        if (ship is AugurShip or VaklasShip)
        {
            Assert.True(ship.Deflector is null);
        }
    }

    [Fact]
    public void TestRegularShipAndVaklasInSpace()
    {
        var regularShip = new RegularShip(Money);
        var vaklas = new VaklasShip(Money);
        regularShip.BuyPlasmaFuel(Money);
        vaklas.BuyPlasmaFuel(Money);
        var ships = new List<Ship> { regularShip, vaklas };
        var environment = new SpaceEnvironment();
        var route = new Route(new List<Section> { new(environment, 5) });
        var service = new ShipService();
        Assert.Equal(regularShip, service.ChooseOptimalShip(route, ships));
    }

    [Fact]
    public void TestAugurStella()
    {
        var augur = new AugurShip(Money);
        var stella = new StellaShip(Money);
        augur.BuyGravitonFuel(Money);
        stella.BuyGravitonFuel(Money);
        var ships = new List<Ship> { augur, stella };
        var environment = new HighDensityEnvironment();
        environment.AddChannel(50);
        var route = new Route(new List<Section> { new(environment) });
        var service = new ShipService();
        Assert.Equal(stella, service.ChooseOptimalShip(route, ships));
    }

    [Fact]
    public void TestRegularShipAndVaklasInNitride()
    {
        var regularShip = new RegularShip(Money);
        var vaklas = new VaklasShip(Money);
        regularShip.BuyPlasmaFuel(Money);
        vaklas.BuyPlasmaFuel(Money);
        var ships = new List<Ship> { regularShip, vaklas };
        var environment = new NitrideParticlesEnvironment();
        var route = new Route(new List<Section> { new(environment, 100) });
        var service = new ShipService();
        Assert.Equal(vaklas, service.ChooseOptimalShip(route, ships));
    }

    [Fact]
    public void Route()
    {
        var highDensityEnvironment = new HighDensityEnvironment();
        var spaceEnvironment = new SpaceEnvironment();
        highDensityEnvironment.AddChannel(100);
        highDensityEnvironment.AddObstacle(new Flash());
        var route = new Route(new List<Section> { new(highDensityEnvironment), new(spaceEnvironment) });
        var augur = new AugurShip(Money);
        augur.BuyGravitonFuel(FuelMoney);
        augur.BuyPlasmaFuel(FuelMoney);
        augur.Deflector?.AddPhotonDeflector();
        var service = new ShipService();
        Assert.Equal(Status.Success, service.PassRoute(route, augur).Status);
    }
}