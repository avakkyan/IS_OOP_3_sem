using System;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;

public class DeepcoolPf600 : IDeepcoolPowerUnit, ICloneable
{
    private int _peakLoad = 600;

    public DeepcoolPf600()
    {
        PeakLoad = _peakLoad;
    }

    public int PeakLoad { get; private set; }

    public DeepcoolPf600 UpdatePeakLoad(int peakLoad)
    {
        var deepcoolPf600 = (DeepcoolPf600)Clone();
        deepcoolPf600.PeakLoad = peakLoad;
        return deepcoolPf600;
    }

    public object Clone()
    {
        return new CougarVte600();
    }
}