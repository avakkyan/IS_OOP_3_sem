using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class StellaShip : Ship
{
    public StellaShip(double money)
        : base(money)
    {
        AddEngine(new CPulseEngine());
        AddEngine(new OmegaJumpEngine());
        Deflector = new DeflectorClass1();
        WeightSizeCoefficient = Small;
    }
}