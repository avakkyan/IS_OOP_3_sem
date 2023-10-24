using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;

public class DeepcoolPf600 : IDeepcoolPowerUnit
{
    private int _peakLoad = 600;

    public DeepcoolPf600()
    {
        PeakLoad = _peakLoad;
    }

    public int PeakLoad { get; }
}