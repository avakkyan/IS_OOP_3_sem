using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts;

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
    public Deflector? Deflector { get; protected set; }
    public Body? Body { get; protected set; }
    public double Money { get; }
    public double WeightSizeCoefficient { get; protected set; }
    public bool HasAntiNitrineEmitter { get; protected set; }
    public bool IsCrewAlive { get; private set; }
    protected static double WeightSizeSmall => Small;
    protected static double WeightSizeMiddle => Middle;
    protected static double WeightSizeBig => Big;
    public bool HasPulseEngine()
    {
        return _engines.Exists(x => x.Type == EngineType.Pulse);
    }

    public bool HasJumpEngine()
    {
        return _engines.Exists(x => x.Type == EngineType.Jump);
    }

    public bool HasPulseEngineClassE()
    {
        return HasPulseEngine() && _engines.Exists(x => x.Class == EngineClass.E);
    }

    public void DestroyDeflector()
    {
        Deflector = null;
    }

    public void KillCrew()
    {
        IsCrewAlive = false;
    }

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