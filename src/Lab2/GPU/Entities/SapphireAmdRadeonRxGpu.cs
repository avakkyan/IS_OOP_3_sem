using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

public class SapphireAmdRadeonRxGpu : IAmdGpu
{
    private static double _sapphireAmdRadeonHeight = 260;
    private static double _sapphireAmdRadeonWidth = 119.85;
    private static int _sapphireAmdRadeonVideoMemoryCapacity = 12;
    private static double _sapphireAmdRadeonPciEVersion = 4.0;
    private static int _sapphireAmdRadeonChipFrequency = 2321;
    private static int _sapphireAmdRadeonPowerConsumption = 230;

    public SapphireAmdRadeonRxGpu()
    {
        GpuHeight = _sapphireAmdRadeonHeight;
        GpuWidth = _sapphireAmdRadeonWidth;
        GpuVideoMemoryCapacity = _sapphireAmdRadeonVideoMemoryCapacity;
        GpuPciEVersion = _sapphireAmdRadeonPciEVersion;
        GpuChipFrequency = _sapphireAmdRadeonChipFrequency;
        GpuPowerConsumption = _sapphireAmdRadeonPowerConsumption;
    }

    public double GpuHeight { get; }
    public double GpuWidth { get; }
    public int GpuVideoMemoryCapacity { get; }
    public double GpuPciEVersion { get; }
    public int GpuChipFrequency { get; }
    public int GpuPowerConsumption { get; }
}