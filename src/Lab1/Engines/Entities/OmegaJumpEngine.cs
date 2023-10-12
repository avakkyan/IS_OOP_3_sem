using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class OmegaJumpEngine : IJumpEngine
{
    private const double OmegaSpeed = 10;
    private const double OmegaFuelConsumption = 30;
    private const double OmegaRange = 300;

    public OmegaJumpEngine()
    {
        Speed = OmegaSpeed;
        FuelConsumption = OmegaFuelConsumption;
        Range = OmegaRange;
    }

    public double Speed { get; }
    public double FuelConsumption { get; }
    public double Range { get; }
    public double CalculateFuelAmount(double distance)
    {
        return Math.Log(CalculateTime(distance)) * FuelConsumption;
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