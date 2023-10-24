using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class GigabyteGeForceGpuRtxGpu : IGeForceGpu, ICloneable
{
    private const double _gigabyteGeForceHeight = 261;
    private const double _gigabyteGeForceWidth = 126;
    private const int _gigabyteGeForceVideoMemoryCapacity = 12;
    private const double _gigabyteGeForcePciEVersion = 4.0;
    private const int _gigabyteGeForceChipFrequency = 1920;
    private const int _gigabyteGeForcePowerConsumption = 200;

    public GigabyteGeForceGpuRtxGpu()
    {
        GpuHeight = _gigabyteGeForceHeight;
        GpuWidth = _gigabyteGeForceWidth;
        GpuVideoMemoryCapacity = _gigabyteGeForceVideoMemoryCapacity;
        GpuPciEVersion = _gigabyteGeForcePciEVersion;
        GpuChipFrequency = _gigabyteGeForceChipFrequency;
        GpuPowerConsumption = _gigabyteGeForcePowerConsumption;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int GpuPowerConsumption { get; private set; }

    public GigabyteGeForceGpuRtxGpu UpdateGpuHeight(double gpuHeight)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpuRtxGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuHeight = gpuHeight;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpuRtxGpu UpdateGpuWidth(double gpuWidth)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpuRtxGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuWidth = gpuWidth;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpuRtxGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpuRtxGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpuRtxGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpuRtxGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuPciEVersion = gpuPciEVersion;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpuRtxGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpuRtxGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuChipFrequency = gpuChipFrequency;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpuRtxGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpuRtxGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuPowerConsumption = gpuPowerConsumption;
        return gigabyteGeForceGpuRtxGpu;
    }

    public object Clone()
    {
        return new GigabyteGeForceGpuRtxGpu();
    }
}