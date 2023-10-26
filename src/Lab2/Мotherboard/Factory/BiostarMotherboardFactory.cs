using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Factory;

public class BiostarMotherboardFactory : IMotherboardFactory
{
    public IMotherboard CreateMotherboard()
    {
        return new BiostarMotherboard();
    }
}