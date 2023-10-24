using Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;

public class CpuTwoCoresFactory : ICpuFactory
{
    public IAmdCpu CreateAmdCpu()
    {
        return new CpuAmdAthlon200Ge();
    }

    public IIntelCpu CreateIntelCpu()
    {
        return new CpuIntelCorei3();
    }
}