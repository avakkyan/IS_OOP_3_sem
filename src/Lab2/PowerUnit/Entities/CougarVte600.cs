using System;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;

public class CougarVte600 : ICougarPowerUnit, ICloneable
{
    private int _peakLoad = 600;

    public CougarVte600()
    {
        PeakLoad = _peakLoad;
    }

    public int PeakLoad { get; private set; }

    public CougarVte600 UpdatePeakLoad(int peakLoad)
    {
        var cougarVte600 = (CougarVte600)Clone();
        cougarVte600.PeakLoad = peakLoad;
        return cougarVte600;
    }

    public object Clone()
    {
        return new CougarVte600();
    }
}