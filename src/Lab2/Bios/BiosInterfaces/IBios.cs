using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;

public interface IBios
{
    int BiosType { get; }
    double BiosVersion { get; }
    IList<IMyСpu> CpuList { get; }
    bool CheckBios();
}