using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

public class CpuAmdAthlon : IAmdCpu, ICloneable
{
    private const double _athlonCoreFrequency = 3.2;
    private const int _athlonNumberOfCores = 2;
    private const int _athlonMemoryFrequencies = 4800;
    private const int _athlonHeatRelease = 35;
    private const int _athlonPowerConsumption = 35;
    private const string _athlonName = "CpuAmdAthlon";
    private MySocket _athlonGeSocket = new MySocketAm4();

    public CpuAmdAthlon()
    {
        CoreFrequency = _athlonCoreFrequency;
        NumberOfCores = _athlonNumberOfCores;
        MemoryFrequencies = _athlonMemoryFrequencies;
        HeatRelease = _athlonHeatRelease;
        PowerConsumption = _athlonPowerConsumption;
        IsVideoCore = false;
        Name = _athlonName;
        CpuSocket = _athlonGeSocket;
    }

    public double CoreFrequency { get; private set; }
    public int NumberOfCores { get; private set; }
    public bool IsVideoCore { get; private set; }
    public int MemoryFrequencies { get; private set; }
    public int HeatRelease { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public MySocket CpuSocket { get; private set; }
    public CpuAmdAthlon UpdateCoreFrequency(double coreFrequency)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon)Clone();
        cpuAmdAthlon200Ge.CoreFrequency = coreFrequency;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon UpdateNumberOfCores(int numberOfCores)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon)Clone();
        cpuAmdAthlon200Ge.NumberOfCores = numberOfCores;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon UpdateVideoCore(bool isVideoCore)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon)Clone();
        cpuAmdAthlon200Ge.IsVideoCore = isVideoCore;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon UpdateMemoryFrequencies(int memoryFrequencies)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon)Clone();
        cpuAmdAthlon200Ge.MemoryFrequencies = memoryFrequencies;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon UpdateHeatRelease(int heatRelease)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon)Clone();
        cpuAmdAthlon200Ge.HeatRelease = heatRelease;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon UpdatePowerConsumption(int powerConsumption)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon)Clone();
        cpuAmdAthlon200Ge.PowerConsumption = powerConsumption;
        return cpuAmdAthlon200Ge;
    }

    public CpuAmdAthlon UpdateName(string name)
    {
        var cpuAmdAthlon200Ge = (CpuAmdAthlon)Clone();
        cpuAmdAthlon200Ge.Name = name;
        return cpuAmdAthlon200Ge;
    }

    public object Clone()
    {
        return new CpuAmdAthlon();
    }
}