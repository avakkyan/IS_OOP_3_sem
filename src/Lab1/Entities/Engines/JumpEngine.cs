using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class JumpEngine : Engine
{
    private const double FuelConsumptionAlpha = 10;
    private const double FuelConsumptionGamma = 20;
    private const double FuelConsumptionOmega = 30;
    private const double RangeAlpha = 100;
    private const double RangeGamma = 200;
    private const double RangeOmega = 300;
    private readonly List<EngineClass> _engineClasses = new() { EngineClass.Alpha, EngineClass.Omega, EngineClass.Gamma };
    public JumpEngine(EngineClass engineClass)
    {
        if (!_engineClasses.Contains(engineClass))
        {
            throw new ArgumentException("Wrong Class for Jump Engine");
        }

        Type = EngineType.Jump;
        Class = engineClass;
        FuelConsumption = Class switch
        {
            EngineClass.Alpha => FuelConsumptionAlpha,
            EngineClass.Omega => FuelConsumptionOmega,
            EngineClass.Gamma => FuelConsumptionGamma,
            _ => throw new ArgumentException("Invalid Class"),
        };
        Range = Class switch
        {
            EngineClass.Alpha => RangeAlpha,
            EngineClass.Omega => RangeOmega,
            EngineClass.Gamma => RangeGamma,
            _ => throw new ArgumentException("Invalid Class"),
        };
    }

    public double Range { get; }

    public override double CalculateFuelAmount(double distance)
    {
        if (Range < distance)
        {
            throw new SpaceException("Ship is lost");
        }

        double t = CalculateTime(distance);
        return Class switch
        {
            EngineClass.Alpha => t * FuelConsumption,
            EngineClass.Omega => Math.Log(t) * FuelConsumption,
            EngineClass.Gamma => Math.Pow(t, 2) * FuelConsumption,
            _ => throw new ArgumentException("Invalid Class"),
        };
    }

    public override double CalculateFuelAmount(Section section)
    {
        if (section is null)
        {
            throw new ArgumentException("Section is null");
        }

        if (section.Environment.Channels is null)
        {
            throw new ArgumentException("Invalid environment");
        }

        double amount = section.Environment.Channels.Sum(CalculateFuelAmount);
        return amount;
    }
}