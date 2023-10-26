using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios.Interfaces;

public interface IBios
{
    int BiosType { get; }
    double BiosVersion { get; }
    IList<IMyСpu> CpuList { get; }
}