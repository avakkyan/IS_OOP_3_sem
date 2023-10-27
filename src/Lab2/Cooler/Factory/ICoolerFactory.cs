﻿using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Factory;

public interface ICoolerFactory
{
    ICooler CreateCooler();
}