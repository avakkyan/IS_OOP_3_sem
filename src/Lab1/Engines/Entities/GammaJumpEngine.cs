using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class GammaJumpEngine : IJumpEngine
{
    private const double GammaSpeed = 10;
    private const double GammaFuelConsumption = 20;
    private const double GammaRange = 200;

    public GammaJumpEngine()
    {
        Speed = GammaSpeed;
        FuelConsumption = GammaFuelConsumption;
        Range = GammaRange;
    }

    public double Speed { get; }
    public double FuelConsumption { get; }
    public double Range { get; }
    public double CalculateFuelAmount(double distance)
    {
        if (Range < distance)
        {
            throw new SpaceException("Ship is lost");
        }

        return Math.Pow(CalculateTime(distance), 2) * FuelConsumption;
    }

    public double CalculateFuelAmount(Section section)
    {
        if (section.Environment is HighDensityEnvironment highDensityEnvironment)
        {
            return highDensityEnvironment.Channels.Sum(CalculateFuelAmount);
        }

        throw new SpaceException("Wrong environment");
    }

    public double CalculateTime(double distance)
    {
        return distance / Speed;
    }

    public double CalculateTime(Section section)
    {
        if (section.Environment is HighDensityEnvironment highDensityEnvironment)
        {
            return highDensityEnvironment.Channels.Sum(CalculateTime);
        }

        throw new SpaceException("Wrong environment");
    }
}