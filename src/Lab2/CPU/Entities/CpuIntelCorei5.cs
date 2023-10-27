﻿using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuIntelCorei5 : IIntelCpu, ICloneable
{
    private const double _i5coreFrequency = 2.5;
    private const int _i5NumberOfCores = 6;
    private const int _i5MemoryFrequencies = 4800;
    private const int _i5HeatRelease = 65;
    private const int _i5PowerConsumption = 65;
    private const string _i5Name = "CpuIntelCorei5";
    private MySocket _i5Socket = new MySocketLga1700();

    public CpuIntelCorei5()
    {
        CoreFrequency = _i5coreFrequency;
        NumberOfCores = _i5NumberOfCores;
        MemoryFrequencies = _i5MemoryFrequencies;
        HeatRelease = _i5HeatRelease;
        PowerConsumption = _i5PowerConsumption;
        IsVideoCore = false;
        Name = _i5Name;
        CpuSocket = _i5Socket;
    }

    public double CoreFrequency { get; private set; }
    public int NumberOfCores { get; private set; }
    public bool IsVideoCore { get; private set; }
    public int MemoryFrequencies { get; private set; }
    public int HeatRelease { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public MySocket CpuSocket { get; private set; }
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

    public CpuIntelCorei5 UpdateVideoCore(bool isVideoCore)
    {
        var cpuIntelCorei5 = (CpuIntelCorei5)Clone();
        cpuIntelCorei5.IsVideoCore = isVideoCore;
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

    public CpuIntelCorei5 UpdateName(string name)
    {
        var cpuIntelCorei5 = (CpuIntelCorei5)Clone();
        cpuIntelCorei5.Name = name;
        return cpuIntelCorei5;
    }

    public object Clone()
    {
        return new CpuIntelCorei5();
    }
}