using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class CoolerDeepcoolGammaxx300 : ICooler
{
    private const double _DeepcoolGammaxx300Dimensions = 1239687.35;
    private const int _DeepcoolGammaxx300TDP = 130;

    public CoolerDeepcoolGammaxx300()
    {
        CoolerDimensions = _DeepcoolGammaxx300Dimensions;
        CoolerTDP = _DeepcoolGammaxx300TDP;
    }

    public double CoolerDimensions { get; }
    public int CoolerTDP { get; }
}