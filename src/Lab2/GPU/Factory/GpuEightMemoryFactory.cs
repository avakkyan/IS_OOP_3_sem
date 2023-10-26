using Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Factory;

public class GpuEightMemoryFactory : IGpuFactory
{
    public IGeForceGpu CreateGeForceGpu()
    {
        return new MsiGeForceGpu();
    }

    public IAmdGpu CreateAmdGpu()
    {
        return new PowerColorAmdGpu();
    }
}