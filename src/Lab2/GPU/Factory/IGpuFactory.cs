using Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Factory;

public interface IGpuFactory
{
    public MyGpu CreateGpu(
        double height,
        double width,
        int memoryCapcity,
        double pciEVersion,
        int chipFrequency,
        int powerConsumption,
        string name);
}