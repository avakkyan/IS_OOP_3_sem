using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuIntelCorei7 : IСpu
{
    private static double _i7coreFrequency = 3.4;
    private static int _i7NumberOfCores = 16;
    private static int _i7MemoryFrequencies = 5600;
    private static int _i7cHeatRelease = 253;
    private static int _i7PowerConsumption = 125;
    private bool _i7cIsVideoCore;

    public CpuIntelCorei7()
    {
        CoreFrequency = _i7coreFrequency;
        NumberOfCores = _i7NumberOfCores;
        IsVideoCore = _i7cIsVideoCore;
        MemoryFrequencies = _i7MemoryFrequencies;
        HeatRelease = _i7cHeatRelease;
        PowerConsumption = _i7PowerConsumption;
    }

    public double CoreFrequency { get; }
    public int NumberOfCores { get; }
    public bool IsVideoCore { get; }
    public int MemoryFrequencies { get; }
    public int HeatRelease { get; }
    public int PowerConsumption { get; }
}