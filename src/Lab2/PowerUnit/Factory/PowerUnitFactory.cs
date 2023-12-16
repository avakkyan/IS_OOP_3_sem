using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Factory;

public class PowerUnitFactory : IPowerUnitFactory
{
    public IPowerUnit CreatePowerUnit(
        int peakLoad,
        int powerConsumption,
        string name)
    {
        return new MyPowerUnit(
            peakLoad,
            powerConsumption,
            name);
    }
}