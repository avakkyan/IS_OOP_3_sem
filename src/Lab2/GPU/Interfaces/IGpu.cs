using Itmo.ObjectOrientedProgramming.Lab2.DataBase;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

public interface IGpu : IComputerDetail
{
    double GpuHeight { get; }
    double GpuWidth { get; }
    int GpuVideoMemoryCapacity { get; }
    double GpuPciEVersion { get; }
    int GpuChipFrequency { get; }
}