using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

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
        return Math.Pow(CalculateTime(distance), 2) * FuelConsumption;
    }

    public double CalculateFuelAmount(Section section)
    {
        var environment = (HighDensityEnvironment)section.Environment;
        return environment.Channels.Sum(CalculateFuelAmount);
    }

    public double CalculateTime(double distance)
    {
        return distance / Speed;
    }

    public double CalculateTime(Section section)
    {
        var environment = (HighDensityEnvironment)section.Environment;
        return environment.Channels.Sum(CalculateFuelAmount);
    }
}