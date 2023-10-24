using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuAmd5Ryzen2400Ge : IAmdCpu, ICloneable
{
    private static double _ryzen2400CoreFrequency = 3.6;
    private static int _ryzen2400NumberOfCores = 4;
    private static int _ryzen2400MemoryFrequencies = 2933;
    private static int _ryzen2400HeatRelease = 35;
    private static int _ryzen2400PowerConsumption = 35;
    private MySocket _mySocket = new MySocketAm4();
    public CpuAmd5Ryzen2400Ge()
    {
        CoreFrequency = _ryzen2400CoreFrequency;
        NumberOfCores = _ryzen2400NumberOfCores;
        MemoryFrequencies = _ryzen2400MemoryFrequencies;
        HeatRelease = _ryzen2400HeatRelease;
        PowerConsumption = _ryzen2400PowerConsumption;
        IsVideoCore = true;
        CpuSoket = _mySocket;
    }

    public double CoreFrequency { get; private set; }
    public int NumberOfCores { get; private set; }
    public bool IsVideoCore { get; private set; }
    public int MemoryFrequencies { get; private set; }
    public int HeatRelease { get; private set; }
    public int PowerConsumption { get; private set; }
    public MySocket CpuSoket { get; }
    public CpuAmd5Ryzen2400Ge UpdateCoreFrequency(double coreFrequency)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen2400Ge)Clone();
        cpuAmd5Ryzen2400Ge.CoreFrequency = coreFrequency;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen2400Ge UpdateNumberOfCores(int numberOfCores)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen2400Ge)Clone();
        cpuAmd5Ryzen2400Ge.NumberOfCores = numberOfCores;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen2400Ge UpdateMemoryFrequencies(int memoryFrequencies)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen2400Ge)Clone();
        cpuAmd5Ryzen2400Ge.MemoryFrequencies = memoryFrequencies;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen2400Ge UpdateHeatRelease(int heatRelease)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen2400Ge)Clone();
        cpuAmd5Ryzen2400Ge.HeatRelease = heatRelease;
        return cpuAmd5Ryzen2400Ge;
    }

    public CpuAmd5Ryzen2400Ge UpdatePowerConsumption(int powerConsumption)
    {
        var cpuAmd5Ryzen2400Ge = (CpuAmd5Ryzen2400Ge)Clone();
        cpuAmd5Ryzen2400Ge.PowerConsumption = powerConsumption;
        return cpuAmd5Ryzen2400Ge;
    }

    public object Clone()
    {
        return new CpuAmd5Ryzen2400Ge();
    }
}