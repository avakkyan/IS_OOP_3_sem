using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Section
{
    public Section(Environment environment, int distance)
    {
        Environment = environment ?? throw new ArgumentException("Environment is null");
        Distance = distance;
    }

    public Environment Environment { get; }
    public int Distance { get;  }
}