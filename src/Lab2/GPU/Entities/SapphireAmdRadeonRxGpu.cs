using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class SapphireAmdRadeonRxGpu : IAmdGpu, ICloneable
{
    private static double _sapphireAmdRadeonHeight = 260;
    private static double _sapphireAmdRadeonWidth = 119.85;
    private static int _sapphireAmdRadeonVideoMemoryCapacity = 12;
    private static double _sapphireAmdRadeonPciEVersion = 4.0;
    private static int _sapphireAmdRadeonChipFrequency = 2321;
    private static int _sapphireAmdRadeonPowerConsumption = 230;

    public SapphireAmdRadeonRxGpu()
    {
        GpuHeight = _sapphireAmdRadeonHeight;
        GpuWidth = _sapphireAmdRadeonWidth;
        GpuVideoMemoryCapacity = _sapphireAmdRadeonVideoMemoryCapacity;
        GpuPciEVersion = _sapphireAmdRadeonPciEVersion;
        GpuChipFrequency = _sapphireAmdRadeonChipFrequency;
        GpuPowerConsumption = _sapphireAmdRadeonPowerConsumption;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int GpuPowerConsumption { get; private set; }
    public SapphireAmdRadeonRxGpu UpdateGpuHeight(double gpuHeight)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdRadeonRxGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuHeight = gpuHeight;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdRadeonRxGpu UpdateGpuWidth(double gpuWidth)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdRadeonRxGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuWidth = gpuWidth;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdRadeonRxGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdRadeonRxGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdRadeonRxGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdRadeonRxGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuPciEVersion = gpuPciEVersion;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdRadeonRxGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdRadeonRxGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuChipFrequency = gpuChipFrequency;
        return sapphireAmdRadeonRxGpu;
    }

    public SapphireAmdRadeonRxGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var sapphireAmdRadeonRxGpu = (SapphireAmdRadeonRxGpu)Clone();
        sapphireAmdRadeonRxGpu.GpuPowerConsumption = gpuPowerConsumption;
        return sapphireAmdRadeonRxGpu;
    }

    public object Clone()
    {
        return new SapphireAmdRadeonRxGpu();
    }
}