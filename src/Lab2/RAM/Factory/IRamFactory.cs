using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;

public interface IRamFactory
{
    IRam CreateRam();
}