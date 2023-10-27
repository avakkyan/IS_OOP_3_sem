using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class SapphireAmdGpu : IAmdGpu, ICloneable
{
    private const double _sapphireAmdHeight = 260;
    private const double _sapphireAmdWidth = 119.85;
    private const int _sapphireAmdVideoMemoryCapacity = 12;
    private const double _sapphireAmdPciEVersion = 4.0;
    private const int _sapphireAmdChipFrequency = 2321;
    private const int _sapphireAmdPowerConsumption = 230;
    private const string _sapphireAmdName = "SapphireAmdGpu";

    public SapphireAmdGpu()
    {
        GpuHeight = _sapphireAmdHeight;
        GpuWidth = _sapphireAmdWidth;
        GpuVideoMemoryCapacity = _sapphireAmdVideoMemoryCapacity;
        GpuPciEVersion = _sapphireAmdPciEVersion;
        GpuChipFrequency = _sapphireAmdChipFrequency;
        PowerConsumption = _sapphireAmdPowerConsumption;
        Name = _sapphireAmdName;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public SapphireAmdGpu UpdateGpuHeight(double gpuHeight)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuHeight = gpuHeight;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdGpu UpdateGpuWidth(double gpuWidth)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuWidth = gpuWidth;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuPciEVersion = gpuPciEVersion;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuChipFrequency = gpuChipFrequency;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdGpu)Clone();
        sapphireAmdRadeonRxGpu.PowerConsumption = gpuPowerConsumption;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdGpu UpdateGpuName(string name)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdGpu)Clone();
        sapphireAmdRadeonRxGpu.Name = name;
        return sapphireAmdRadeonRxGpu;
    }

    public object Clone()
    {
        return new SapphireAmdGpu();
    }
}