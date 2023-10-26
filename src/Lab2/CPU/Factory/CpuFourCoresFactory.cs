using Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;

public class CpuFourCoresFactory : ICpuFactory
{
    public IAmdCpu CreateAmdCpu()
    {
        return new CpuAmd5Ryzen();
    }

    public IIntelCpu CreateIntelCpu()
    {
        return new CpuIntelCorei5();
    }
}