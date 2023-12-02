using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;

public class AdataXmpFactory : IRamFactory
{
    private readonly IList<int> adataRamFrequencyJedec = new List<int>();
    public IRam CreateRam(
        int powerConsumption,
        int ramMemory,
        string name,
        int dDrStandard)
    {
        adataRamFrequencyJedec.Add(15);
        adataRamFrequencyJedec.Add(15);
        adataRamFrequencyJedec.Add(17);
        return new MyRam(
             powerConsumption,
             ramMemory,
             name,
             dDrStandard,
             adataRamFrequencyJedec);
    }
}