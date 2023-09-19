using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class PulseEngine : Engine
{
    private const double FuelConsumptionC = 10;
    private const double FuelConsumptionE = 20;
    private const double StartUpAmount = 10;
    private readonly List<EngineClass> _engineClasses = new() { EngineClass.E, EngineClass.C };
    public PulseEngine(EngineClass engineClass)
    {
        if (!_engineClasses.Contains(engineClass))
        {
            throw new ArgumentException("Wrong Class for Pulse Engine");
        }

        Type = EngineType.Pulse;
        Class = engineClass;
        FuelConsumption = Class switch
        {
            EngineClass.C => FuelConsumptionC,
            EngineClass.E => FuelConsumptionE,
            _ => throw new ArgumentException("Invalid Class"),
        };
    }

    public double CalculateFuelAmount(double distance)
    {
        return Class switch
        {
            EngineClass.C => StartUpAmount + (distance / Speed * FuelConsumption),
            EngineClass.E => StartUpAmount + (Math.Log((distance / Speed) + 1) * FuelConsumption),
            _ => throw new ArgumentException("Invalid Class"),
        };
    }
}