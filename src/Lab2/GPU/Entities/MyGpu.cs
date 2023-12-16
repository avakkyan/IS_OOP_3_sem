using System;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class MyGpu : IGpu, ICloneable
{
    public MyGpu(
        double height,
        double width,
        int memoryCapcity,
        double pciEVersion,
        int chipFrequency,
        int powerConsumption,
        string name)
    {
        GpuHeight = height;
        GpuWidth = width;
        GpuVideoMemoryCapacity = memoryCapcity;
        GpuPciEVersion = pciEVersion;
        GpuChipFrequency = chipFrequency;
        PowerConsumption = powerConsumption;
        Name = name;
    }

    public double GpuHeight { get; private set; }
    public double GpuWidth { get; private set; }
    public int GpuVideoMemoryCapacity { get; private set; }
    public double GpuPciEVersion { get; private set; }
    public int GpuChipFrequency { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public MyGpu UpdateGpuHeight(double gpuHeight)
    {
        var myGpu = (MyGpu)Clone();
        myGpu.GpuHeight = gpuHeight;
        return myGpu;
    }

    public MyGpu UpdateGpuWidth(double gpuWidth)
    {
        var myGpu = (MyGpu)Clone();
        myGpu.GpuWidth = gpuWidth;
        return myGpu;
    }

    public MyGpu UpdateGpuVideoMemoryCapacity(int gpuVideoMemoryCapacity)
    {
        var myGpu = (MyGpu)Clone();
        myGpu.GpuVideoMemoryCapacity = gpuVideoMemoryCapacity;
        return myGpu;
    }

    public MyGpu UpdateGpuPciEVersion(double gpuPciEVersion)
    {
        var myGpu = (MyGpu)Clone();
        myGpu.GpuPciEVersion = gpuPciEVersion;
        return myGpu;
    }

    public MyGpu UpdateGpuChipFrequency(int gpuChipFrequency)
    {
        var myGpu = (MyGpu)Clone();
        myGpu.GpuChipFrequency = gpuChipFrequency;
        return myGpu;
    }

    public MyGpu UpdateGpuPowerConsumption(int gpuPowerConsumption)
    {
        var myGpu = (MyGpu)Clone();
        myGpu.PowerConsumption = gpuPowerConsumption;
        return myGpu;
    }

    public MyGpu UpdateGpuName(string name)
    {
        var myGpu = (MyGpu)Clone();
        myGpu.Name = name;
        return myGpu;
    }

    public object Clone()
    {
        return new MyGpu(
            GpuHeight,
            GpuWidth,
            GpuVideoMemoryCapacity,
            GpuPciEVersion,
            GpuChipFrequency,
            PowerConsumption,
            Name);
    }
}