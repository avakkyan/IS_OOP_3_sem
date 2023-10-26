using Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.GPU.Factory;

public class GpuTwelveMemoryFactory : IGpuFactory
{
    public IAmdGpu CreateAmdGpu()
    {
        return new SapphireAmdGpu();
    }

    public IGeForceGpu CreateGeForceGpu()
    {
        return new GigabyteGeForceGpu();
    }
}