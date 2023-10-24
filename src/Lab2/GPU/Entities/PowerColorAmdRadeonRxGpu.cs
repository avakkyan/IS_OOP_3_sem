using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class PowerColorAmdRadeonRxGpu : IAmdGpu, ICloneable
{
    private static double _platitGeForceHeight = 294;
    private static double _platitGeForceWidth = 118;
    private static int _platitGeForceVideoMemoryCapacity = 8;
    private static double _platitGeForcePciEVersion = 4.0;
    private static int _platitGeForceChipFrequency = 1410;
    private static int _platitGeForcePowerConsumption = 225;

    public PowerColorAmdRadeonRxGpu()
    {
        GpuHeight = _platitGeForceHeight;
        GpuWidth = _platitGeForceWidth;
        GpuVideoMemoryCapacity = _platitGeForceVideoMemoryCapacity;
        GpuPciEVersion = _platitGeForcePciEVersion;
        GpuChipFrequency = _platitGeForceChipFrequency;
        GpuPowerConsumption = _platitGeForcePowerConsumption;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int GpuPowerConsumption { get; private set; }
    public PowerColorAmdRadeonRxGpu UpdateGpuHeight(double gpuHeight)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdRadeonRxGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuHeight = gpuHeight;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdRadeonRxGpu UpdateGpuWidth(double gpuWidth)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdRadeonRxGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuWidth = gpuWidth;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdRadeonRxGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdRadeonRxGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdRadeonRxGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdRadeonRxGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuPciEVersion = gpuPciEVersion;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdRadeonRxGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdRadeonRxGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuChipFrequency = gpuChipFrequency;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdRadeonRxGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdRadeonRxGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuPowerConsumption = gpuPowerConsumption;
        return powerColorAmdRadeonRxGpu;
    }

    public object Clone()
    {
        return new MsiGeForceRtxGpu();
    }
}