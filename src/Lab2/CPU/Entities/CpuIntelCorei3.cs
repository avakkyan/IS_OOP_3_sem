using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuIntelCorei3 : IIntelCpu, ICloneable
{
    private const double _i3coreFrequency = 3.3;
    private const int _i3NumberOfCores = 4;
    private const int _i3cMemoryFrequencies = 4800;
    private const int _i3cHeatRelease = 89;
    private const int _i3PowerConsumption = 58;
    private const string _i3Name = "CpuIntelCorei3";
    private MySocket _i3Socket = new MySocketLga1700();

    public CpuIntelCorei3()
    {
        CoreFrequency = _i3coreFrequency;
        NumberOfCores = _i3NumberOfCores;
        MemoryFrequencies = _i3cMemoryFrequencies;
        HeatRelease = _i3cHeatRelease;
        PowerConsumption = _i3PowerConsumption;
        IsVideoCore = false;
        Name = _i3Name;
        CpuSocket = _i3Socket;
    }

    public double CoreFrequency { get; private set; }
    public int NumberOfCores { get; private set; }
    public bool IsVideoCore { get; private set; }
    public int MemoryFrequencies { get; private set; }
    public int HeatRelease { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public MySocket CpuSocket { get; private set; }

    public CpuIntelCorei3 UpdateCoreFrequency(double coreFrequency)
    {
        var cpuIntelCorei3 = (CpuIntelCorei3)Clone();
        cpuIntelCorei3.CoreFrequency = coreFrequency;
        return cpuIntelCorei3;
    }

    public CpuIntelCorei3 UpdateNumberOfCores(int numberOfCores)
    {
        var cpuIntelCorei3 = (CpuIntelCorei3)Clone();
        cpuIntelCorei3.NumberOfCores = numberOfCores;
        return cpuIntelCorei3;
    }

    public CpuIntelCorei3 UpdateVideoCore(bool isVideoCore)
    {
        var cpuIntelCorei3 = (CpuIntelCorei3)Clone();
        cpuIntelCorei3.IsVideoCore = isVideoCore;
        return cpuIntelCorei3;
    }

    public CpuIntelCorei3 UpdateMemoryFrequencies(int memoryFrequencies)
    {
        var cpuIntelCorei3 = (CpuIntelCorei3)Clone();
        cpuIntelCorei3.MemoryFrequencies = memoryFrequencies;
        return cpuIntelCorei3;
    }

    public CpuIntelCorei3 UpdateHeatRelease(int heatRelease)
    {
        var cpuIntelCorei3 = (CpuIntelCorei3)Clone();
        cpuIntelCorei3.HeatRelease = heatRelease;
        return cpuIntelCorei3;
    }

    public CpuIntelCorei3 UpdatePowerConsumption(int powerConsumption)
    {
        var cpuIntelCorei3 = (CpuIntelCorei3)Clone();
        cpuIntelCorei3.PowerConsumption = powerConsumption;
        return cpuIntelCorei3;
    }

    public CpuIntelCorei3 UpdatePowerName(string name)
    {
        var cpuIntelCorei3 = (CpuIntelCorei3)Clone();
        cpuIntelCorei3.Name = name;
        return cpuIntelCorei3;
    }

    public object Clone()
    {
        return new CpuIntelCorei3();
    }
}