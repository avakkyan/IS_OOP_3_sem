using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuAmd5Ryzen : IAmdCpu, ICloneable
{
    private const double _ryzenCoreFrequency = 3.6;
    private const int _ryzenNumberOfCores = 4;
    private const int _ryzenMemoryFrequencies = 2933;
    private const int _ryzenHeatRelease = 35;
    private const string _ryzenName = "CpuAmd5Ryzen5";
    private const int _ryzenPowerConsumption = 35;
    private MySocket _ryzenSocket = new MySocketAm4();
    public CpuAmd5Ryzen()
    {
        CoreFrequency = _ryzenCoreFrequency;
        NumberOfCores = _ryzenNumberOfCores;
        MemoryFrequencies = _ryzenMemoryFrequencies;
        HeatRelease = _ryzenHeatRelease;
        PowerConsumption = _ryzenPowerConsumption;
        IsVideoCore = true;
        Name = _ryzenName;
        CpuSocket = _ryzenSocket;
    }

    public double CoreFrequency { get; private set; }
    public int NumberOfCores { get; private set; }
    public bool IsVideoCore { get; private set; }
    public int MemoryFrequencies { get; private set; }
    public int HeatRelease { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public MySocket CpuSocket { get; }
    public CpuAmd5Ryzen UpdateCoreFrequency(double coreFrequency)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen)Clone();
        cpuAmd5Ryzen2400Ge.CoreFrequency = coreFrequency;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen UpdateNumberOfCores(int numberOfCores)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen)Clone();
        cpuAmd5Ryzen2400Ge.NumberOfCores = numberOfCores;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen UpdateMemoryFrequencies(int memoryFrequencies)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen)Clone();
        cpuAmd5Ryzen2400Ge.MemoryFrequencies = memoryFrequencies;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen UpdateVideoCore(bool isVideoCore)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen)Clone();
        cpuAmd5Ryzen2400Ge.IsVideoCore = isVideoCore;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen UpdateHeatRelease(int heatRelease)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen)Clone();
        cpuAmd5Ryzen2400Ge.HeatRelease = heatRelease;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen UpdatePowerConsumption(int powerConsumption)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen)Clone();
        cpuAmd5Ryzen2400Ge.PowerConsumption = powerConsumption;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen UpdateName(string name)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen)Clone();
        cpuAmd5Ryzen2400Ge.Name = name;
        return cpuAmd5Ryzen2400Ge;
    }

    public object Clone()
    {
        return new CpuAmd5Ryzen();
    }
}