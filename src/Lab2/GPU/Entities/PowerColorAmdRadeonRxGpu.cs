using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class PowerColorAmdRadeonRxGpu : IAmdGpu
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

    public double GpuHeight { get; }
    public double GpuWidth { get; }
    public int GpuVideoMemoryCapacity { get; }
    public double GpuPciEVersion { get; }
    public int GpuChipFrequency { get; }
    public int GpuPowerConsumption { get; }
}