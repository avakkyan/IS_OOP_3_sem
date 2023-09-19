using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class Ship
{
    private const int Small = 1;
    private const int Middle = 2;
    private const int Big = 3;

    private List<Engine> _engines = new();
    private List<Fuel> _fuels = new();

    // private protected List<Engine> _engines = new();
    // private protected List<Deflector> _deflectors = new();
    protected Ship(double money)
    {
        Money = money;
        HasAntiNitrineEmitter = false;
    }

    public IReadOnlyCollection<Engine> Engines => _engines.AsReadOnly();
    public IReadOnlyCollection<Fuel> Fuels => _fuels.AsReadOnly();
    public Deflector? Deflector { get; init; }
    public Body? Body { get; set; }
    public double Money { get; }
    public double WeightSizeCoefficient { get; set; }
    public bool HasAntiNitrineEmitter { get; init; }
    protected static double WeightSizeSmall => Small;
    protected static double WeightSizeMiddle => Middle;
    protected static double WeightSizeBig => Big;

    protected void AddEngine(Engine engine)
    {
        if (engine is null)
        {
            throw new ArgumentException("Engine is null");
        }

        _engines.Add(engine);
        switch (engine.Type)
        {
            case EngineType.Pulse:
                AddFuel(new Fuel(FuelType.Plasma));
                break;
            case EngineType.Jump:
                AddFuel(new Fuel(FuelType.Graviton));
                break;
            default:
                throw new ArgumentException("Wrong Engine type");
        }
    }

    private void AddFuel(Fuel fuel)
    {
        _fuels.Add(fuel);
    }
}