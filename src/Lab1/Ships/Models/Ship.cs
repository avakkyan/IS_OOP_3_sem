using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Fuels;
using Itmo.ObjectOrientedProgramming.Lab1.Fuels.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Fuels.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public abstract class Ship
{
    protected const int Small = 1;
    protected const int Middle = 2;
    protected const int Big = 3;

    private List<IEngine> _engines = new();
    private List<IFuel> _fuels = new();

    protected Ship(double money)
    {
        Money = money;
        HasAntiNitrineEmitter = false;
    }

    public IReadOnlyCollection<IEngine> Engines => _engines.AsReadOnly();
    public IReadOnlyCollection<IFuel> Fuels => _fuels.AsReadOnly();
    public IDeflector? Deflector { get; protected set; }
    public IBody Body { get; protected set; } = new BodyClass1();
    public double Money { get; }
    public double WeightSizeCoefficient { get; protected set; }
    public bool HasAntiNitrineEmitter { get; protected set; }
    public bool IsCrewAlive { get; private set; }

    // protected static double WeightSizeSmall = 1;
    // protected static double WeightSizeMiddle => Middle;
    // protected static double WeightSizeBig => Big;
    public bool HasPulseEngine()
    {
        return _engines.Exists(x => x is IPulseEngine);
    }

    public bool HasJumpEngine()
    {
        return _engines.Exists(x => x is IJumpEngine);
    }

    public bool HasPulseEngineClassE()
    {
        return _engines.Exists(x => x is EPulseEngine);
    }

    public void DestroyDeflector()
    {
        Deflector = null;
    }

    public void KillCrew()
    {
        IsCrewAlive = false;
    }

    public void BuyPlasmaFuel(double money)
    {
        if (Money < money)
        {
            throw new SpaceException("Not enough money");
        }

        IFuel? plasmaFuel = Fuels.FirstOrDefault(x => x is Plasma);
        plasmaFuel?.Add(money / FuelExchange.GetFuelExchange.PlasmaCost);
    }

    public void BuyGravitonFuel(double money)
    {
        if (Money < money)
        {
            throw new SpaceException("Not enough money");
        }

        IFuel? gravitonFuel = Fuels.FirstOrDefault(x => x is Graviton);
        gravitonFuel?.Add(money / FuelExchange.GetFuelExchange.GravitonCost);
    }

    protected void AddEngine(IEngine engine)
    {
        _engines.Add(engine);
        switch (engine)
        {
            case IPulseEngine:
                AddFuel(new Plasma());
                break;
            case IJumpEngine:
                AddFuel(new Graviton());
                break;
        }
    }

    private void AddFuel(IFuel fuel)
    {
        _fuels.Add(fuel);
    }
}