using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class JumpEngine : Engine
{
    private const double FuelConsumptionAlpha = 10;
    private const double FuelConsumptionGamma = 20;
    private const double FuelConsumptionOmega = 30;
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
    }

    public double CalculateFuelAmount(double distance)
    {
        double t = distance / Speed;
        return Class switch
        {
            EngineClass.Alpha => t * FuelConsumption,
            EngineClass.Omega => Math.Log(t) * FuelConsumption,
            EngineClass.Gamma => Math.Pow(t, 2) * FuelConsumption,
            _ => throw new ArgumentException("Invalid Class"),
        };
    }
}