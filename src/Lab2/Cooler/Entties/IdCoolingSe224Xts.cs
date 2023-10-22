using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class IdCoolingSe224Xts : ICooler
{
    private const double _DeepcoolGammaxx300Dimensions = 1359000;
    private const int _DeepcoolGammaxx300TDP = 220;

    public IdCoolingSe224Xts()
    {
        CoolerDimensions = _DeepcoolGammaxx300Dimensions;
        CoolerTDP = _DeepcoolGammaxx300TDP;
    }

    public double CoolerDimensions { get; }
    public int CoolerTDP { get; }
}