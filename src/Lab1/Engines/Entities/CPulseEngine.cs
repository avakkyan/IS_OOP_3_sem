using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class CPulseEngine : IPulseEngine
{
    private const double CSpeed = 10;
    private const double CFuelConsumption = 10;
    private const double CStartUpAmount = 10;

    public CPulseEngine()
    {
        Speed = CSpeed;
        FuelConsumption = CFuelConsumption;
        StartUpAmount = CStartUpAmount;
    }

    public double Speed { get; }
    public double FuelConsumption { get; }
    public double StartUpAmount { get; }
    public double CalculateFuelAmount(double distance)
    {
        return StartUpAmount + (CalculateTime(distance) * FuelConsumption);
    }

    public double CalculateFuelAmount(Section section)
    {
        return CalculateFuelAmount(section.Distance);
    }

    public double CalculateTime(double distance)
    {
        return distance / Speed;
    }

    public double CalculateTime(Section section)
    {
        return CalculateTime(section.Distance);
    }
}