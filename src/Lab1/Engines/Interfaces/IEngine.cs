using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;

public interface IEngine
{
    double Speed { get; }
    double FuelConsumption { get; }

    double CalculateFuelAmount(double distance);

    double CalculateFuelAmount(Section section);
    double CalculateTime(double distance);
    double CalculateTime(Section section);
}