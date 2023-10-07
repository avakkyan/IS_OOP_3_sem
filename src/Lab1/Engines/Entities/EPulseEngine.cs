using System;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class EPulseEngine : IPulseEngine
{
    public double Speed { get; init; } = 10;
    public double FuelConsumption { get; init; } = 20;
    public double StartUpAmount { get; init; } = 10;
    public double CalculateFuelAmount(double distance)
    {
        return StartUpAmount + (Math.Log(CalculateTime(distance) + 1) * FuelConsumption);
    }

    public double CalculateFuelAmount(Section section)
    {
        if (section is null)
        {
            throw new ArgumentException("Section is null");
        }

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