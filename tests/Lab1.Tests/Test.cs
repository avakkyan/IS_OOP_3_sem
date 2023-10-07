using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

// using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Test
{
    [Fact]
    public void TestRegularShipAndAugurShip()
    {
        double money = 5000;
        var regularShip = new RegularShip(money);
        var augur = new AugurShip(money);
        regularShip.BuyPlasmaFuel(money);
        augur.BuyGravitonFuel(money / 2);
        augur.BuyPlasmaFuel(money / 2);

        var environment = new HighDensityEnvironment();
        environment.AddChannel(200);
        var route = new Route(new List<Section> { new(environment) });
        var service = new ShipService();
        SpaceException exception = Assert.Throws<SpaceException>(() => service.PassRoute(route, regularShip));
        Assert.Equal("Ship doesn't have an engine to enter the environment", exception.Message);
        exception = Assert.Throws<SpaceException>(() => service.PassRoute(route, augur));
        Assert.Equal("Ship is lost", exception.Message);
    }

    [Fact]
    public void TestVaklasShipWithAndWithoutPhotonDeflector()
    {
        double money = 5000;
        var vaklas = new VaklasShip(money);
        var vaklasPhoton = new VaklasShip(money);
        vaklasPhoton.Deflector?.AddPhotonDeflector();
        vaklas.BuyPlasmaFuel(money / 2);
        vaklas.BuyGravitonFuel(money / 2);
        vaklasPhoton.BuyPlasmaFuel(money / 2);
        vaklasPhoton.BuyGravitonFuel(money / 2);

        var environment = new HighDensityEnvironment();
        environment.AddChannel(200);
        environment.AddObstacle(new Flash());
        var route = new Route(new List<Section> { new(environment) });
        var service = new ShipService();

        // SpaceException exception = Assert.Throws<SpaceException>(() => service.PassRoute(route, vaklas));
        // Assert.Equal("Crew is dead", exception.Message);
        service.PassRoute(route, vaklasPhoton);
        Assert.True(vaklasPhoton.IsCrewAlive);
    }
}