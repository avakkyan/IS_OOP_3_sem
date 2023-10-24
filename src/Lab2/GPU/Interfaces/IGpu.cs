namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

public interface IGpu
{
    double GpuHeight { get; }
    double GpuWidth { get; }
    int GpuVideoMemoryCapacity { get; }
    double GpuPciEVersion { get; }
    int GpuChipFrequency { get; }
    int GpuPowerConsumption { get; }
}