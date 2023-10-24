using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuIntelCorei5 : IIntelCpu, ICloneable
{
    private static double _i5coreFrequency = 2.5;
    private static int _i5NumberOfCores = 6;
    private static int _i5MemoryFrequencies = 4800;
    private static int _i5HeatRelease = 65;
    private static int _i5PowerConsumption = 65;
    private MySocket _mySocket = new MySocketLga1700();

    public CpuIntelCorei5()
    {
        CoreFrequency = _i5coreFrequency;
        NumberOfCores = _i5NumberOfCores;
        MemoryFrequencies = _i5MemoryFrequencies;
        HeatRelease = _i5HeatRelease;
        PowerConsumption = _i5PowerConsumption;
        IsVideoCore = false;
        CpuSoket = _mySocket;
    }

    public double CoreFrequency { get; private set; }
    public int NumberOfCores { get; private set; }
    public bool IsVideoCore { get; private set; }
    public int MemoryFrequencies { get; private set; }
    public int HeatRelease { get; private set; }
    public int PowerConsumption { get; private set; }
    public MySocket CpuSoket { get; private set; }
    public CpuIntelCorei5 UpdateCoreFrequency(double coreFrequency)
    {
        var cpuIntelCorei5 = (CpuIntelCorei5)Clone();
        cpuIntelCorei5.CoreFrequency = coreFrequency;
        return cpuIntelCorei5;
    }

    public CpuIntelCorei5 UpdateNumberOfCores(int numberOfCores)
    {
        var cpuIntelCorei5 = (CpuIntelCorei5)Clone();
        cpuIntelCorei5.NumberOfCores = numberOfCores;
        return cpuIntelCorei5;
    }

    public CpuIntelCorei5 UpdateMemoryFrequencies(int memoryFrequencies)
    {
        var cpuIntelCorei5 = (CpuIntelCorei5)Clone();
        cpuIntelCorei5.MemoryFrequencies = memoryFrequencies;
        return cpuIntelCorei5;
    }

    public CpuIntelCorei5 UpdateHeatRelease(int heatRelease)
    {
        var cpuIntelCorei5 = (CpuIntelCorei5)Clone();
        cpuIntelCorei5.HeatRelease = heatRelease;
        return cpuIntelCorei5;
    }

    public CpuIntelCorei5 UpdatePowerConsumption(int powerConsumption)
    {
        var cpuIntelCorei5 = (CpuIntelCorei5)Clone();
        cpuIntelCorei5.PowerConsumption = powerConsumption;
        return cpuIntelCorei5;
    }

    public object Clone()
    {
        return new CpuIntelCorei5();
    }
}