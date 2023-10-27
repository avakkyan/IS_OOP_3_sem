using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class MsiGeForceGpu : IGeForceGpu, ICloneable
{
    private const double _msiGeForceRtxHeight = 199;
    private const double _msiGeForceRtxWidth = 120;
    private const int _msiGeForceRtxMemoryCapacity = 8;
    private const double _msiGeForceRtxPciEVersion = 4.0;
    private const int _msiGeForceRtxChipFrequency = 1830;
    private const int _msiGeForceRtxPowerConsumption = 115;
    private const string _msiGeForceName = "MsiGeForceGpu";

    public MsiGeForceGpu()
    {
        GpuHeight = _msiGeForceRtxHeight;
        GpuWidth = _msiGeForceRtxWidth;
        GpuVideoMemoryCapacity = _msiGeForceRtxMemoryCapacity;
        GpuPciEVersion = _msiGeForceRtxPciEVersion;
        GpuChipFrequency = _msiGeForceRtxChipFrequency;
        PowerConsumption = _msiGeForceRtxPowerConsumption;
        Name = _msiGeForceName;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public MsiGeForceGpu UpdateGpuHeight(double gpuHeight)
    {
        var msiGeForceRtxGpu = (MsiGeForceGpu)Clone();
        msiGeForceRtxGpu.GpuHeight = gpuHeight;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceGpu UpdateGpuWidth(double gpuWidth)
    {
        var msiGeForceRtxGpu = (MsiGeForceGpu)Clone();
        msiGeForceRtxGpu.GpuWidth = gpuWidth;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var msiGeForceRtxGpu = (MsiGeForceGpu)Clone();
        msiGeForceRtxGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var msiGeForceRtxGpu = (MsiGeForceGpu)Clone();
        msiGeForceRtxGpu.GpuPciEVersion = gpuPciEVersion;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var msiGeForceRtxGpu = (MsiGeForceGpu)Clone();
        msiGeForceRtxGpu.GpuChipFrequency = gpuChipFrequency;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var msiGeForceRtxGpu = (MsiGeForceGpu)Clone();
        msiGeForceRtxGpu.PowerConsumption = gpuPowerConsumption;
        return msiGeForceRtxGpu;
    }

    public MsiGeForceGpu UpdateGpuName(string name)
    {
        var msiGeForceRtxGpu = (MsiGeForceGpu)Clone();
        msiGeForceRtxGpu.Name = name;
        return msiGeForceRtxGpu;
    }

    public object Clone()
    {
        return new MsiGeForceGpu();
    }
}