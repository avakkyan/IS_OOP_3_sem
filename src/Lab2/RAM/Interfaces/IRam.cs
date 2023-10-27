using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.DataBase;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Interfaces;

public interface IRam : IComputerDetail
{
    int TotalMemoryCapacity { get; }
    int RamDdrStandard { get; }
    IList<int> RamFrequencyJedec { get; }
}