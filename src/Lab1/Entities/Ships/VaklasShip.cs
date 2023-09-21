using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class VaklasShip : Ship
{
    public VaklasShip(double money)
        : base(money)
    {
        AddEngine(new PulseEngine(EngineClass.E));
        AddEngine(new JumpEngine(EngineClass.Gamma));
        Deflector = new Deflector(DeflectorClass.Class1);
        Body = new Body(BodyClass.Class2);
        WeightSizeCoefficient = WeightSizeMiddle;
    }
}