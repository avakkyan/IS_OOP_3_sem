using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;

public class CpuLga1700Factory : ICpuFactory
{
    private readonly MySocket socketLga1700 = new MySocketLga1700();
    public IMyСpu CreateAmdCpu(
        double coreFrequency,
        int numberOfCores,
        int memoryFrequencies,
        int heatRelease,
        int powerConsumption,
        bool isVideoCore,
        string name)
    {
        return new Cpu(
            coreFrequency,
            numberOfCores,
            memoryFrequencies,
            heatRelease,
            powerConsumption,
            isVideoCore,
            name,
            socketLga1700);
    }
}