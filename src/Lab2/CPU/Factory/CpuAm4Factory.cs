using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;

public class CpuAm4Factory : ICpuFactory
{
    private readonly MySocket socketAm4 = new MySocketAm4();
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
             socketAm4);
    }
}