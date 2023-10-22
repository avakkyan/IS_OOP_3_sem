namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

public interface IСpu
{
    double CoreFrequency { get; }
    int NumberOfCores { get; }
    bool IsVideoCore { get; }
    int MemoryFrequencies { get; }
    int HeatRelease { get; }
    int PowerConsumption { get; }
}