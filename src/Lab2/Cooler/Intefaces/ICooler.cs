﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;

public interface ICooler
{
    double CoolerDimensions { get; }
    int CoolerTdp { get; }
    IList<MySocket> CoolerSocket { get; }
}