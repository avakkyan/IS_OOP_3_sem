using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;

public class CougarVte600 : ICougarPowerUnit
{
    private int _peakLoad = 600;

    public CougarVte600()
    {
        PeakLoad = _peakLoad;
    }

    public int PeakLoad { get; }
}