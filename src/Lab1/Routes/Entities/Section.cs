using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

public class Section
{
    public Section(IEnvironment environment, double distance = 0)
    {
        Environment = environment ?? throw new ArgumentException("Environment is null");
        if (environment is HighDensityEnvironment highDensityEnvironment)
        {
            Distance = highDensityEnvironment.Channels.Sum();
        }
        else
        {
            Distance = distance;
        }
    }

    public IEnvironment Environment { get; }
    public double Distance { get; }

    public bool TryEnterSection(Ship ship)
    {
        if (ship is null)
        {
            throw new ArgumentException("Ship is null");
        }

        return (Environment is HighDensityEnvironment && ship.HasJumpEngine()) ||
               (Environment is SpaceEnvironment && ship.HasPulseEngine()) ||
               (Environment is NitrideParticlesEnvironment && ship.HasPulseEngineClassE());
    }
}