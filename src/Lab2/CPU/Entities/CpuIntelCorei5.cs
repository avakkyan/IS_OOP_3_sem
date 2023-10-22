using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuIntelCorei5 : IСpu
{
    private static double _i5coreFrequency = 2.5;
    private static int _i5NumberOfCores = 6;
    private static int _i5MemoryFrequencies = 4800;
    private static int _i5HeatRelease = 65;
    private static int _i5PowerConsumption = 65;
    private bool _i5IsVideoCore;

    public CpuIntelCorei5()
    {
        CoreFrequency = _i5coreFrequency;
        NumberOfCores = _i5NumberOfCores;
        IsVideoCore = _i5IsVideoCore;
        MemoryFrequencies = _i5MemoryFrequencies;
        HeatRelease = _i5HeatRelease;
        PowerConsumption = _i5PowerConsumption;
    }

    public double CoreFrequency { get; }
    public int NumberOfCores { get; }
    public bool IsVideoCore { get; }
    public int MemoryFrequencies { get; }
    public int HeatRelease { get; }
    public int PowerConsumption { get; }
}