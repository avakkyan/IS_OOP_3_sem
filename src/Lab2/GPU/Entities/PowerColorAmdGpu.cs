using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class PowerColorAmdGpu : IAmdGpu, ICloneable
{
    private const double _powerColorAmdHeight = 294;
    private const double _powerColorAmdWidth = 118;
    private const int _powerColorAmdMemoryCapacity = 8;
    private const double _powerColorAmdPciEVersion = 4.0;
    private const int _powerColorAmdChipFrequency = 1410;
    private const int _powerColorAmdPowerConsumption = 225;
    private const string _powerColorAmdPowerName = "PowerColorAmdGpu";
    public PowerColorAmdGpu()
    {
        GpuHeight = _powerColorAmdHeight;
        GpuWidth = _powerColorAmdWidth;
        GpuVideoMemoryCapacity = _powerColorAmdMemoryCapacity;
        GpuPciEVersion = _powerColorAmdPciEVersion;
        GpuChipFrequency = _powerColorAmdChipFrequency;
        PowerConsumption = _powerColorAmdPowerConsumption;
        Name = _powerColorAmdPowerName;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public PowerColorAmdGpu UpdateGpuHeight(double gpuHeight)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuHeight = gpuHeight;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdGpu UpdateGpuWidth(double gpuWidth)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuWidth = gpuWidth;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuPciEVersion = gpuPciEVersion;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdGpu)Clone();
        powerColorAmdRadeonRxGpu.GpuChipFrequency = gpuChipFrequency;
        return powerColorAmdRadeonRxGpu;
    }

    public PowerColorAmdGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var powerColorAmdRadeonRxGpu = (PowerColorAmdGpu)Clone();
        powerColorAmdRadeonRxGpu.PowerConsumption = gpuPowerConsumption;
        return powerColorAmdRadeonRxGpu;
    }

    public object Clone()
    {
        return new MsiGeForceGpu();
    }
}