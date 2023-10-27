using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Factory;

public class CoolingIdFactory : ICoolerFactory
{
    public ICooler CreateCooler()
    {
        return new CoolerIdCooling();
    }
}