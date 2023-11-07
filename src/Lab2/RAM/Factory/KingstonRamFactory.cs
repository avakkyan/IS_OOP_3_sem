using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;

public class KingstonRamFactory : IRamFactory
{
    private readonly IList<int> kingstonRamFrequencyJedec = new List<int>();
    public IRam CreateRam(
        int powerConsumption,
        int ramMemory,
        string name,
        int dDrStandard)
    {
        kingstonRamFrequencyJedec.Add(15);
        kingstonRamFrequencyJedec.Add(15);
        kingstonRamFrequencyJedec.Add(17);
        return new MyRam(
            powerConsumption,
            ramMemory,
            name,
            dDrStandard,
            kingstonRamFrequencyJedec);
    }
}