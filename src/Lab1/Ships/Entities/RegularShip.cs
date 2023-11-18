using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class RegularShip : Ship
{
    public RegularShip(double money)
        : base(money)
    {
        AddEngine(new CPulseEngine());
        WeightSizeCoefficient = Small;
    }
}