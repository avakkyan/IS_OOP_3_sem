using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Factory;

public interface ICoolerFactory
{
    ICooler CreateCooler();
}