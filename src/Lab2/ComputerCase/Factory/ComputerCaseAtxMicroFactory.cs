using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Factory;

public class ComputerCaseAtxMicroFactory : IComputerCaseFactory
{
    private readonly List<MyFormFactor> _formFactors = new List<MyFormFactor>();
    public IComputerCase CreateComputerCase(
        int caseHeight,
        int caseWidth,
        int casePowerConsumption,
        string name)
    {
        _formFactors.Add(new MicroAtxFormFactor());
        return new Entities.ComputerCase(
            caseHeight,
            caseWidth,
            casePowerConsumption,
            name,
            _formFactors);
    }
}