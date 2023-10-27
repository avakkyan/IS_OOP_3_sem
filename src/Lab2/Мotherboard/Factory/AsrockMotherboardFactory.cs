using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Factory;

public class AsrockMotherboardFactory : IMotherboardFactory
{
    public IMotherboard CreateMotherboard()
    {
        return new AsrockMotherboard();
    }
}