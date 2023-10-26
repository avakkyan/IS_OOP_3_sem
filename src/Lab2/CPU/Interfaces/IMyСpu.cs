using Itmo.ObjectOrientedProgramming.Lab2.DataBase;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

public interface IMyСpu : IComputerDetail
{
    double CoreFrequency { get; }
    int NumberOfCores { get; }
    bool IsVideoCore { get; }
    int MemoryFrequencies { get; }
    int HeatRelease { get; }
    MySocket CpuSocket { get; }
}