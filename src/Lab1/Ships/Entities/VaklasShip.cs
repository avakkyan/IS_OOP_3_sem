using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class VaklasShip : Ship
{
    public VaklasShip(double money)
        : base(money)
    {
        AddEngine(new EPulseEngine());
        AddEngine(new GammaJumpEngine());
        Deflector = new DeflectorClassOne();
        Body = new BodyClassTwo();
        WeightSizeCoefficient = Middle;
    }
}