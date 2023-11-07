using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;

public interface IRamFactory
{
    public IRam CreateRam(
        int powerConsumption,
        int ramMemory,
        string name,
        int dDrStandard);
}