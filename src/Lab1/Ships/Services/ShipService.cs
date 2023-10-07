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
            Success success;
            try
            {
                success = PassRoute(route, ship);
            }
            catch (SpaceException)
            {
                continue;
            }

            if (success.FuelAmount < minFuelAmount)
            {
                optimalShip = ship;
                minFuelAmount = success.FuelAmount;
            }
        }

        if (optimalShip is null)
        {
            throw new SpaceException("Optimal ship doesn't exist");
        }

        return optimalShip;
    }

    public Success PassRoute(Route route, Ship ship)
    {
        double time = 0;
        double fuelAmount = 0;
        foreach (Section section in route.Sections)
        {
            if (!section.TryEnterSection(ship))
            {
                throw new SpaceException("Ship doesn't have an engine to enter the environment");
            }

            foreach (IObstacle obstacle in section.Environment.Obstacles)
            {
                obstacle.Hit(ship);

                if (ship.Body.HitPoints <= 0)
                {
                    throw new SpaceException("Ship is destroyed");
                }

                if (!ship.IsCrewAlive)
                {
                    throw new SpaceException("Crew is dead");
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
                throw new SpaceException("Not enough fuel");
            }

            fuel.Reduce(amount);
            fuelAmount += amount;
            time += engine.CalculateTime(section);
        }

        return new Success(time, fuelAmount);
    }
}