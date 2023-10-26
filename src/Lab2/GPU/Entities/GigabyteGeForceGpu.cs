using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class GigabyteGeForceGpu : IGeForceGpu, ICloneable
{
    private const double _gigabyteGeForceHeight = 261;
    private const double _gigabyteGeForceWidth = 126;
    private const int _gigabyteGeForceVideoMemoryCapacity = 12;
    private const double _gigabyteGeForcePciEVersion = 4.0;
    private const int _gigabyteGeForceChipFrequency = 1920;
    private const int _gigabyteGeForcePowerConsumption = 200;
    private const string _gigabyteGeForceName = "GigabyteGeForceGpu";

    public GigabyteGeForceGpu()
    {
        GpuHeight = _gigabyteGeForceHeight;
        GpuWidth = _gigabyteGeForceWidth;
        GpuVideoMemoryCapacity = _gigabyteGeForceVideoMemoryCapacity;
        GpuPciEVersion = _gigabyteGeForcePciEVersion;
        GpuChipFrequency = _gigabyteGeForceChipFrequency;
        PowerConsumption = _gigabyteGeForcePowerConsumption;
        Name = _gigabyteGeForceName;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public GigabyteGeForceGpu UpdateGpuHeight(double gpuHeight)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuHeight = gpuHeight;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpu UpdateGpuWidth(double gpuWidth)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuWidth = gpuWidth;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuPciEVersion = gpuPciEVersion;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpu)Clone();
        gigabyteGeForceGpuRtxGpu.GpuChipFrequency = gpuChipFrequency;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpu)Clone();
        gigabyteGeForceGpuRtxGpu.PowerConsumption = gpuPowerConsumption;
        return gigabyteGeForceGpuRtxGpu;
    }

    public GigabyteGeForceGpu UpdateGpuName(string name)
    {
        var gigabyteGeForceGpuRtxGpu = (GigabyteGeForceGpu)Clone();
        gigabyteGeForceGpuRtxGpu.Name = name;
        return gigabyteGeForceGpuRtxGpu;
    }

    public object Clone()
    {
        return new GigabyteGeForceGpu();
    }
}