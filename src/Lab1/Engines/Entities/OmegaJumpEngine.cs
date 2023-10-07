using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class OmegaJumpEngine : IJumpEngine
{
    public double Speed { get; init; } = 10;
    public double FuelConsumption { get; init; } = 30;
    public double Range { get; } = 300;
    public double CalculateFuelAmount(double distance)
    {
        if (Range < distance)
        {
            throw new SpaceException("Ship is lost");
        }

        return Math.Log(CalculateTime(distance)) * FuelConsumption;
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