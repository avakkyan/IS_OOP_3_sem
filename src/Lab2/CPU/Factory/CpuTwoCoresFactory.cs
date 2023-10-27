using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;

public class CpuTwoCoresFactory : ICpuFactory
{
    public IAmdCpu CreateAmdCpu()
    {
        return new CpuAmdAthlon();
    }

    public IIntelCpu CreateIntelCpu()
    {
        return new CpuIntelCorei3();
    }
}