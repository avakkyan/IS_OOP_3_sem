using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Factory;

public interface IGpuFactory
{
    public IGeForceGpu CreateGeForceGpu();
    public IAmdGpu CreateAmdGpu();
}