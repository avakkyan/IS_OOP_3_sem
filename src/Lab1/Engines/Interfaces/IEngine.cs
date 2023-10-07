using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;

public interface IEngine
{
    public double Speed { get; init; }
    public double FuelConsumption { get; init; }

    public double CalculateFuelAmount(double distance);

    public double CalculateFuelAmount(Section section);
    public double CalculateTime(double distance);
    public double CalculateTime(Section section);
}