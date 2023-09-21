using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class StellaShip : Ship
{
    public StellaShip(double money)
        : base(money)
    {
        AddEngine(new PulseEngine(EngineClass.C));
        AddEngine(new JumpEngine(EngineClass.Omega));
        Deflector = new Deflector(DeflectorClass.Class1);
        Body = new Body(BodyClass.Class1);
        WeightSizeCoefficient = WeightSizeSmall;
    }
}