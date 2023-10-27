using Itmo.ObjectOrientedProgramming.Lab2.DataBase;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;

public interface IGpu : IComputerDetail
{
    double GpuHeight { get; }
    double GpuWidth { get; }
    int GpuVideoMemoryCapacity { get; }
    double GpuPciEVersion { get; }
    int GpuChipFrequency { get; }
}