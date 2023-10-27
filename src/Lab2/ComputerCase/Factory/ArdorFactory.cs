﻿using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Factory;

public class ArdorFactory : IComputerCaseFactory
{
    public IComputerCase CreateComputerCase()
    {
        return new ArdorGamingCase();
    }
}