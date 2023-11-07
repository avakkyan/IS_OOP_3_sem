using System;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;

public class MyPowerUnit : IPowerUnit, ICloneable
{
    public MyPowerUnit(
        int peakLoad,
        int powerConsumption,
        string name)
    {
        PeakLoad = peakLoad;
        PowerConsumption = powerConsumption;
        Name = name;
    }

    public int PeakLoad { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public MyPowerUnit UpdatePeakLoad(int peakLoad)
    {
        var powerUnit = (MyPowerUnit)Clone();
        powerUnit.PeakLoad = peakLoad;
        return powerUnit;
    }

    public MyPowerUnit UpdatePowerConsumption(int powerConsumption)
    {
        var powerUnit = (MyPowerUnit)Clone();
        powerUnit.PowerConsumption = powerConsumption;
        return powerUnit;
    }

    public MyPowerUnit UpdateName(string name)
    {
        var powerUnit = (MyPowerUnit)Clone();
        powerUnit.Name = name;
        return powerUnit;
    }

    public object Clone()
    {
        return new MyPowerUnit(
            PeakLoad,
            PowerConsumption,
            Name);
    }
}