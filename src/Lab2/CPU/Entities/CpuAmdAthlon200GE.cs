using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuAmdAthlon200GE : IСpu
{
    private static double _athlon200CoreFrequency = 3.2;
    private static int _athlon200NumberOfCores = 2;
    private static int _athlon200MemoryFrequencies = 4800;
    private static int _athlon200HeatRelease = 35;
    private static int _athlon200PowerConsumption = 35;
    private bool _athlon200IsVideoCore = true;

    public CpuAmdAthlon200GE()
    {
        CoreFrequency = _athlon200CoreFrequency;
        NumberOfCores = _athlon200NumberOfCores;
        MemoryFrequencies = _athlon200MemoryFrequencies;
        HeatRelease = _athlon200HeatRelease;
        PowerConsumption = _athlon200PowerConsumption;
        IsVideoCore = _athlon200IsVideoCore;
    }

    public double CoreFrequency { get; }
    public int NumberOfCores { get; }
    public bool IsVideoCore { get; }
    public int MemoryFrequencies { get; }
    public int HeatRelease { get; }
    public int PowerConsumption { get; }
}