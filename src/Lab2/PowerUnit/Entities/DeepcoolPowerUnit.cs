using System;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;

public class DeepcoolPowerUnit : IDeepcoolPowerUnit, ICloneable
{
    private const int _deepcoolpeakLoad = 600;
    private const int _deepcoolpowerConsumption = 0;
    private const string _deepcoolName = "DeepcoolPowerUnit";
    public DeepcoolPowerUnit()
    {
        PeakLoad = _deepcoolpeakLoad;
        PowerConsumption = _deepcoolpowerConsumption;
        Name = _deepcoolName;
    }

    public int PowerConsumption { get; private set; }
    public int PeakLoad { get; private set; }
    public string Name { get; private set; }

    public DeepcoolPowerUnit UpdatePeakLoad(int peakLoad)
    {
        var deepcoolPf600 = (DeepcoolPowerUnit)Clone();
        deepcoolPf600.PeakLoad = peakLoad;
        return deepcoolPf600;
    }

    public DeepcoolPowerUnit UpdatePowerConsumption(int powerConsumption)
    {
        var deepcoolPf600 = (DeepcoolPowerUnit)Clone();
        deepcoolPf600.PowerConsumption = powerConsumption;
        return deepcoolPf600;
    }

    public DeepcoolPowerUnit UpdateName(string name)
    {
        var deepcoolPf600 = (DeepcoolPowerUnit)Clone();
        deepcoolPf600.Name = name;
        return deepcoolPf600;
    }

    public object Clone()
    {
        return new DeepcoolPowerUnit();
    }
}