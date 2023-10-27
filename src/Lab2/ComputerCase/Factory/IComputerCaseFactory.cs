﻿using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Factory;

public interface IComputerCaseFactory
{
    IComputerCase CreateComputerCase();
}