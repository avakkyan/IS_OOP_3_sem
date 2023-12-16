using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Fuels.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Fuels.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

public class ShipService : IShipService
{
    public Ship ChooseOptimalShip(Route route, IReadOnlyCollection<Ship> ships)
    {
        double minFuelAmount = double.MaxValue;
        Ship? optimalShip = null;
        foreach (Ship ship in ships)
        {
            Result result = PassRoute(route, ship);
            if (result.Status != Status.Success)
            {
                continue;
            }

            if (result.FuelAmount < minFuelAmount)
            {
                optimalShip = ship;
                minFuelAmount = result.FuelAmount;
            }
        }

        if (optimalShip is null)
        {
            throw new SpaceException("Optimal ship doesn't exist");
        }

        return optimalShip;
    }

    public Result PassRoute(Route route, Ship ship)
    {
        double time = 0;
        double fuelAmount = 0;
        foreach (Section section in route.Sections)
        {
            Result result = section.TryEnterSection(ship);
            if (result.Status != Status.Success)
            {
                return result;
            }

            foreach (IObstacle obstacle in section.Environment.Obstacles)
            {
                obstacle.Hit(ship);

                if (ship.Body.HitPoints <= 0)
                {
                    return new Result(Status.ShipIsDestroyed);
                }

                if (!ship.IsCrewAlive)
                {
                    return new Result(Status.CrewIsDead);
                }
            }

            IEngine engine;
            IFuel fuel;
            if (section.Environment is HighDensityEnvironment)
            {
                engine = ship.Engines.First(x => x is IJumpEngine);
                fuel = ship.Fuels.First(x => x is Graviton);
            }
            else
            {
                engine = ship.Engines.First(x => x is IPulseEngine);
                fuel = ship.Fuels.First(x => x is Plasma);
            }

            double amount = engine.CalculateFuelAmount(section);
            if (fuel.Amount < amount)
            {
                return new Result(Status.NotEnoughFuel);
            }

            fuel.Reduce(amount);
            fuelAmount += amount;
            time += engine.CalculateTime(section);
        }

        return new Result(Status.Success, time, fuelAmount);
    }
}