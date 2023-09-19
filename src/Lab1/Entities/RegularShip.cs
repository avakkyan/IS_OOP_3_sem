using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class RegularShip : Ship
{
    public RegularShip(double money)
        : base(money)
    {
        AddEngine(new PulseEngine(EngineClass.C));
        Body = new Body(BodyClass.Class1);
        WeightSizeCoefficient = WeightSizeSmall;
    }
}