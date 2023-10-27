using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Factory;

public interface IPowerUnitFactory
{
    IPowerUnit CreatePowerUnit();
}