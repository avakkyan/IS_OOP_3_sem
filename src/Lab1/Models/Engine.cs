using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public abstract class Engine
{
    private const double InitialSpeed = 10;
    protected Engine()
    {
        Speed = InitialSpeed;
    }

    public EngineType Type { get; set; }
    public EngineClass Class { get; init; }
    public double Speed { get; }
    public double FuelConsumption { get; init; }

    public virtual double CalculateFuelAmount(double distance)
    {
        return distance;
    }

    public double CalculateTime(double distance)
    {
        return distance / Speed;
    }

    public virtual double CalculateFuelAmount(Section section)
    {
        return 0;
    }
}