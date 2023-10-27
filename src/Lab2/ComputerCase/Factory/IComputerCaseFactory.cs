using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Factory;

public interface IComputerCaseFactory
{
    IComputerCase CreateComputerCase();
}