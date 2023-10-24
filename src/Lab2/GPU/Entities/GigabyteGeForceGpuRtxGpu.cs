using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class GigabyteGeForceGpuRtxGpu : IGeForceGpu
{
    private static double _gigabyteGeForceHeight = 261;
    private static double _gigabyteGeForceWidth = 126;
    private static int _gigabyteGeForceVideoMemoryCapacity = 12;
    private static double _gigabyteGeForcePciEVersion = 4.0;
    private static int _gigabyteGeForceChipFrequency = 1920;
    private static int _gigabyteGeForcePowerConsumption = 200;

    public GigabyteGeForceGpuRtxGpu()
    {
        GpuHeight = _gigabyteGeForceHeight;
        GpuWidth = _gigabyteGeForceWidth;
        GpuVideoMemoryCapacity = _gigabyteGeForceVideoMemoryCapacity;
        GpuPciEVersion = _gigabyteGeForcePciEVersion;
        GpuChipFrequency = _gigabyteGeForceChipFrequency;
        GpuPowerConsumption = _gigabyteGeForcePowerConsumption;
    }

    public double GpuHeight { get; }
    public double GpuWidth { get; }
    public int GpuVideoMemoryCapacity { get; }
    public double GpuPciEVersion { get; }
    public int GpuChipFrequency { get; }
    public int GpuPowerConsumption { get; }
}