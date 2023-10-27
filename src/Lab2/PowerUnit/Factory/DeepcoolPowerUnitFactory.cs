using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Factory;

public class DeepcoolPowerUnitFactory : IPowerUnitFactory
{
    public IPowerUnit CreatePowerUnit()
    {
        return new DeepcoolPowerUnit();
    }
}