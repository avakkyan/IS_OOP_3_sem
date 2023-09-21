using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class AugurShip : Ship
{
    public AugurShip(double money)
        : base(money)
    {
        AddEngine(new PulseEngine(EngineClass.E));
        AddEngine(new JumpEngine(EngineClass.Alpha));
        Deflector = new Deflector(DeflectorClass.Class3);
        Body = new Body(BodyClass.Class3);
        WeightSizeCoefficient = WeightSizeBig;
    }
}