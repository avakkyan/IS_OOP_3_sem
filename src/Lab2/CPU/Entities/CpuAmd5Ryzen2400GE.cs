using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuAmd5Ryzen2400GE : IСpu
{
    private static double _ryzen2400CoreFrequency = 3.6;
    private static int _ryzen2400NumberOfCores = 4;
    private static int _ryzen2400MemoryFrequencies = 2933;
    private static int _ryzen2400HeatRelease = 35;
    private static int _ryzen2400PowerConsumption = 35;
    private bool _ryzen2400IsVideoCore = true;

    public CpuAmd5Ryzen2400GE()
    {
        CoreFrequency = _ryzen2400CoreFrequency;
        NumberOfCores = _ryzen2400NumberOfCores;
        MemoryFrequencies = _ryzen2400MemoryFrequencies;
        HeatRelease = _ryzen2400HeatRelease;
        PowerConsumption = _ryzen2400PowerConsumption;
        IsVideoCore = _ryzen2400IsVideoCore;
    }

    public double CoreFrequency { get; }
    public int NumberOfCores { get; }
    public bool IsVideoCore { get; }
    public int MemoryFrequencies { get; }
    public int HeatRelease { get; }
    public int PowerConsumption { get; }
}