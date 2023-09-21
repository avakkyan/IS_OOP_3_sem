using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class ShipService : IShipService
{
    // private const double Money = 0;
    public Ship ChooseOptimalShip(Route route, IReadOnlyCollection<Ship> ships)
    {
        if (route is null)
        {
            throw new ArgumentException("Route is null");
        }

        if (ships is null)
        {
            throw new ArgumentException("Ships is null");
        }

        double minFuelAmount = double.MaxValue;
        Ship? optimalShip = null;
        foreach (Ship ship in ships)
        {
            double fuelAmount = 0;
            foreach (Section section in route.Sections)
            {
                if (!section.TryEnterSection(ship))
                {
                    break;
                }

                foreach (Obstacle obstacle in section.Environment.Obstacles)
                {
                    try
                    {
                        obstacle.Hit(ship);
                    }
                    catch (ArgumentException)
                    {
                        break;
                    }

                    if (ship.Body?.HitPoints <= 0 || !ship.IsCrewAlive)
                    {
                        break;
                    }
                }

                Engine? engine;
                if (section.Environment.Type == EnvironmentType.HighDensity)
                {
                    engine = ship.Engines.First(x => x.Type == EngineType.Jump);
                }
                else
                {
                    engine = ship.Engines.First(x => x.Type == EngineType.Pulse);
                }

                fuelAmount += engine.CalculateFuelAmount(section);
            }

            if (fuelAmount != 0 && fuelAmount < minFuelAmount)
            {
                minFuelAmount = fuelAmount;
                optimalShip = ship;
            }
        }

        if (optimalShip is null)
        {
            throw new SpaceException("Optimal ship doesn't exist");
        }

        return optimalShip;
    }

    public void PassRoute(Route route, Ship ship)
    {
        if (route is null)
        {
            throw new ArgumentException("Route is null");
        }

        if (ship is null)
        {
            throw new ArgumentException("Ship is null");
        }

        foreach (Section section in route.Sections)
        {
            if (!section.TryEnterSection(ship))
            {
                throw new SpaceException("Ship doesn't have engine to enter the route's section");
            }

            foreach (Obstacle obstacle in section.Environment.Obstacles)
            {
                try
                {
                    obstacle.Hit(ship);
                }
                catch (ArgumentException)
                {
                    break; // TODO проверить, когда кидается
                }

                if (ship.Body?.HitPoints <= 0 || !ship.IsCrewAlive)
                {
                    break;
                }
            }

            Engine? engine;
            Fuel? fuel;
            if (section.Environment.Type == EnvironmentType.HighDensity)
            {
                engine = ship.Engines.First(x => x.Type == EngineType.Jump);
                fuel = ship.Fuels.First(x => x.Type == FuelType.Graviton);
            }
            else
            {
                engine = ship.Engines.First(x => x.Type == EngineType.Pulse);
                fuel = ship.Fuels.First(x => x.Type == FuelType.Plasma);
            }

            if (fuel.Amount < engine.CalculateFuelAmount(section))
            {
                throw new SpaceException("Not enough fuel");
            }
        }
    }
}