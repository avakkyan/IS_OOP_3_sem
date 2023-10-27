using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Factory;

public interface IGpuFactory
{
    public IGeForceGpu CreateGeForceGpu();
    public IAmdGpu CreateAmdGpu();
}