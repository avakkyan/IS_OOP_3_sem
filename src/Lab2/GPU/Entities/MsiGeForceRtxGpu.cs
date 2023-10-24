using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class MsiGeForceRtxGpu : IGeForceGpu
{
    private static double _msiGeForceRtxHeight = 199;
    private static double _msiGeForceRtxWidth = 120;
    private static int _msiGeForceRtxMemoryCapacity = 8;
    private static double _msiGeForceRtxPciEVersion = 4.0;
    private static int _msiGeForceRtxChipFrequency = 1830;
    private static int _msiGeForceRtxPowerConsumption = 115;

    public MsiGeForceRtxGpu()
    {
        GpuHeight = _msiGeForceRtxHeight;
        GpuWidth = _msiGeForceRtxWidth;
        GpuVideoMemoryCapacity = _msiGeForceRtxMemoryCapacity;
        GpuPciEVersion = _msiGeForceRtxPciEVersion;
        GpuChipFrequency = _msiGeForceRtxChipFrequency;
        GpuPowerConsumption = _msiGeForceRtxPowerConsumption;
    }

    public double GpuHeight { get; }
    public double GpuWidth { get; }
    public int GpuVideoMemoryCapacity { get; }
    public double GpuPciEVersion { get; }
    public int GpuChipFrequency { get; }
    public int GpuPowerConsumption { get; }
}