using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Factory;

public class DeepcoolFactory : ICoolerFactory
{
    public ICooler CreateCooler()
    {
        return new CoolerDeepcoolGammaxx300();
    }
}