using Itmo.ObjectOrientedProgramming.Lab2.RAM.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;

public interface IRamFactory
{
    IRam CreateRam();
}