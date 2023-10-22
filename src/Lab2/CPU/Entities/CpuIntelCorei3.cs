using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuIntelCorei3 : IСpu
{
    private static double _i3coreFrequency = 3.3;
    private static int _i3NumberOfCores = 4;
    private static int _i3cMemoryFrequencies = 4800;
    private static int _i3cHeatRelease = 89;
    private static int _i3PowerConsumption = 58;
    private bool _i3cIsVideoCore;

    public CpuIntelCorei3()
    {
        CoreFrequency = _i3coreFrequency;
        NumberOfCores = _i3NumberOfCores;
        IsVideoCore = _i3cIsVideoCore;
        MemoryFrequencies = _i3cMemoryFrequencies;
        HeatRelease = _i3cHeatRelease;
        PowerConsumption = _i3PowerConsumption;
    }

    public double CoreFrequency { get; }
    public int NumberOfCores { get; }
    public bool IsVideoCore { get; }
    public int MemoryFrequencies { get; }
    public int HeatRelease { get; }
    public int PowerConsumption { get; }
}