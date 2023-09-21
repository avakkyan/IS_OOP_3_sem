using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Section
{
    public Section(Environment environment, double distance)
    {
        Environment = environment ?? throw new ArgumentException("Environment is null");
        Distance = distance;
    }

    public Environment Environment { get; }
    public double Distance { get; }

    public bool TryEnterSection(Ship ship)
    {
        if (ship is null)
        {
            throw new ArgumentException("Ship is null");
        }

        return (Environment.Type == EnvironmentType.HighDensity && ship.HasJumpEngine()) ||
               (Environment.Type == EnvironmentType.Space && ship.HasPulseEngine()) ||
               (Environment.Type == EnvironmentType.NitrideParticles && ship.HasPulseEngineClassE());
    }
}