using System;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class EPulseEngine : IPulseEngine
{
    private const double ESpeed = 10;
    private const double EFuelConsumption = 20;
    private const double EStartUpAmount = 10;

    public EPulseEngine()
    {
        Speed = ESpeed;
        FuelConsumption = EFuelConsumption;
        StartUpAmount = EStartUpAmount;
    }

    public double Speed { get; }
    public double FuelConsumption { get; }
    public double StartUpAmount { get; }
    public double CalculateFuelAmount(double distance)
    {
        return StartUpAmount + (Math.Log(CalculateTime(distance) + 1) * FuelConsumption);
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