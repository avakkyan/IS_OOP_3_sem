﻿using Itmo.ObjectOrientedProgramming.Lab2.RAM.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;

public class KingstonRamFactory : IRamFactory
{
    public IRam CreateRam()
    {
        return new KingstonRam();
    }
}