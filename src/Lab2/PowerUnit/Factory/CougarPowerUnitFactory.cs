using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Factory;

public class CougarPowerUnitFactory : IPowerUnitFactory
{
    public IPowerUnit CreatePowerUnit()
    {
        return new CougarVte600();
    }
}