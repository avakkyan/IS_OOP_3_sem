using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Factory;

public class CougarFactory : IComputerCaseFactory
{
    public IComputerCase CreateComputerCase()
    {
        return new CougarDuofaceCase();
    }
}