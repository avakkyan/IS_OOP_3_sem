using Itmo.ObjectOrientedProgramming.Lab2.RAM.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;

public class AdataXmpFactory : IRamFactory
{
    public IRam CreateRam()
    {
        return new AdataRam();
    }
}