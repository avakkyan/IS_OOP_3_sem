using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;

public interface ICpuFactory
{
    IMyСpu CreateAmdCpu(
        double coreFrequency,
        int numberOfCores,
        int memoryFrequencies,
        int heatRelease,
        int powerConsumption,
        bool isVideoCore,
        string name);
}