using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class AlphaJumpEngine : IJumpEngine
{
    private const double AlphaSpeed = 10;
    private const double AlphaFuelConsumption = 10;
    private const double AlphaRange = 100;

    public AlphaJumpEngine()
    {
        Speed = AlphaSpeed;
        FuelConsumption = AlphaFuelConsumption;
        Range = AlphaRange;
    }

    public double Speed { get; }
    public double FuelConsumption { get; }
    public double Range { get; }
    public double CalculateFuelAmount(double distance)
    {
        return CalculateTime(distance) * FuelConsumption;
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
        return environment.Channels.Sum(CalculateTime);
    }
}