using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class MsiGeForceRtxGpu : IGeForceGpu, ICloneable
{
    private const double _msiGeForceRtxHeight = 199;
    private const double _msiGeForceRtxWidth = 120;
    private const int _msiGeForceRtxMemoryCapacity = 8;
    private const double _msiGeForceRtxPciEVersion = 4.0;
    private const int _msiGeForceRtxChipFrequency = 1830;
    private const int _msiGeForceRtxPowerConsumption = 115;

    public MsiGeForceRtxGpu()
    {
        GpuHeight = _msiGeForceRtxHeight;
        GpuWidth = _msiGeForceRtxWidth;
        GpuVideoMemoryCapacity = _msiGeForceRtxMemoryCapacity;
        GpuPciEVersion = _msiGeForceRtxPciEVersion;
        GpuChipFrequency = _msiGeForceRtxChipFrequency;
        GpuPowerConsumption = _msiGeForceRtxPowerConsumption;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int GpuPowerConsumption { get; private set; }
    public MsiGeForceRtxGpu UpdateGpuHeight(double gpuHeight)
    {
        var msiGeForceRtxGpu = (MsiGeForceRtxGpu)Clone();
        msiGeForceRtxGpu.GpuHeight = gpuHeight;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceRtxGpu UpdateGpuWidth(double gpuWidth)
    {
        var msiGeForceRtxGpu = (MsiGeForceRtxGpu)Clone();
        msiGeForceRtxGpu.GpuWidth = gpuWidth;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceRtxGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var msiGeForceRtxGpu = (MsiGeForceRtxGpu)Clone();
        msiGeForceRtxGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceRtxGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var msiGeForceRtxGpu = (MsiGeForceRtxGpu)Clone();
        msiGeForceRtxGpu.GpuPciEVersion = gpuPciEVersion;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceRtxGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var msiGeForceRtxGpu = (MsiGeForceRtxGpu)Clone();
        msiGeForceRtxGpu.GpuChipFrequency = gpuChipFrequency;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceRtxGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var msiGeForceRtxGpu = (MsiGeForceRtxGpu)Clone();
        msiGeForceRtxGpu.GpuPowerConsumption = gpuPowerConsumption;
        return msiGeForceRtxGpu;
    }

    public object Clone()
    {
        return new MsiGeForceRtxGpu();
    }
}