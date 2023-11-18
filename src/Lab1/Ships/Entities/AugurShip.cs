using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class AugurShip : Ship
{
    public AugurShip(double money)
        : base(money)
    {
        AddEngine(new EPulseEngine());
        AddEngine(new AlphaJumpEngine());
        Deflector = new DeflectorClassThree();
        Body = new BodyClassThree();
        WeightSizeCoefficient = Big;
    }
}