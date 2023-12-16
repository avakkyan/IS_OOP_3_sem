using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class Cpu : IMyСpu, ICloneable
{
    public Cpu(
        double coreFrequency,
        int numberOfCores,
        int memoryFrequencies,
        int heatRelease,
        int powerConsumption,
        bool isVideoCore,
        string name,
        MySocket cpuSocket)
    {
        CoreFrequency = coreFrequency;
        NumberOfCores = numberOfCores;
        IsVideoCore = isVideoCore;
        MemoryFrequencies = memoryFrequencies;
        HeatRelease = heatRelease;
        PowerConsumption = powerConsumption;
        Name = name;
        CpuSocket = cpuSocket;
    }

    public double CoreFrequency { get; private set; }
    public int NumberOfCores { get; private set; }
    public bool IsVideoCore { get; private set; }
    public int MemoryFrequencies { get; private set; }
    public int HeatRelease { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public MySocket CpuSocket { get; }
    public Cpu UpdateCoreFrequency(double coreFrequency)
    {
        var cpu = (Cpu)Clone();
        cpu.CoreFrequency = coreFrequency;
        return cpu;
    }

    public Cpu UpdateNumberOfCores(int numberOfCores)
    {
        var cpu = (Cpu)Clone();
        cpu.NumberOfCores = numberOfCores;
        return cpu;
    }

    public Cpu UpdateMemoryFrequencies(int memoryFrequencies)
    {
        var cpu = (Cpu)Clone();
        cpu.MemoryFrequencies = memoryFrequencies;
        return cpu;
    }

    public Cpu UpdateVideoCore(bool isVideoCore)
    {
        var cpu = (Cpu)Clone();
        cpu.IsVideoCore = isVideoCore;
        return cpu;
    }

    public Cpu UpdateHeatRelease(int heatRelease)
    {
        var cpu = (Cpu)Clone();
        cpu.HeatRelease = heatRelease;
        return cpu;
    }

    public Cpu UpdatePowerConsumption(int powerConsumption)
    {
        var cpu = (Cpu)Clone();
        cpu.PowerConsumption = powerConsumption;
        return cpu;
    }

    public Cpu UpdateName(string name)
    {
        var cpu = (Cpu)Clone();
        cpu.Name = name;
        return cpu;
    }

    public object Clone()
    {
        return new Cpu(
            CoreFrequency,
            NumberOfCores,
            MemoryFrequencies,
            HeatRelease,
            PowerConsumption,
            IsVideoCore,
            Name,
            CpuSocket);
    }
}