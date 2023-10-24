using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;

public interface ICpuFactory
{
    IAmdCpu CreateAmdCpu();
    IIntelCpu CreateIntelCpu();
}