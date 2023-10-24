using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuAmdAthlon200Ge : IAmdCpu, ICloneable
{
    private static double _athlon200CoreFrequency = 3.2;
    private static int _athlon200NumberOfCores = 2;
    private static int _athlon200MemoryFrequencies = 4800;
    private static int _athlon200HeatRelease = 35;
    private static int _athlon200PowerConsumption = 35;
    private MySocket _mySocket = new MySocketAm4();

    public CpuAmdAthlon200Ge()
    {
        CoreFrequency = _athlon200CoreFrequency;
        NumberOfCores = _athlon200NumberOfCores;
        MemoryFrequencies = _athlon200MemoryFrequencies;
        HeatRelease = _athlon200HeatRelease;
        PowerConsumption = _athlon200PowerConsumption;
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
    public CpuAmdAthlon200Ge UpdateCoreFrequency(double coreFrequency)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon200Ge)Clone();
        cpuAmdAthlon200Ge.CoreFrequency = coreFrequency;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon200Ge UpdateNumberOfCores(int numberOfCores)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon200Ge)Clone();
        cpuAmdAthlon200Ge.NumberOfCores = numberOfCores;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon200Ge UpdateMemoryFrequencies(int memoryFrequencies)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon200Ge)Clone();
        cpuAmdAthlon200Ge.MemoryFrequencies = memoryFrequencies;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon200Ge UpdateHeatRelease(int heatRelease)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon200Ge)Clone();
        cpuAmdAthlon200Ge.HeatRelease = heatRelease;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon200Ge UpdatePowerConsumption(int powerConsumption)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon200Ge)Clone();
        cpuAmdAthlon200Ge.PowerConsumption = powerConsumption;
        return cpuAmdAthlon200Ge;
    }

    public object Clone()
    {
        return new CpuAmdAthlon200Ge();
    }
}