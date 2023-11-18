using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

namespace Itmo.ObjectOrientedProgramming.Lab1.Routes.Entities;

public class Section
{
    public Section(IEnvironment environment, double distance = 0)
    {
        Environment = environment;
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

    public Result TryEnterSection(Ship ship)
    {
        if (Environment is HighDensityEnvironment environment && ship.HasJumpEngine())
        {
            var engine = (IJumpEngine)ship.Engines.First(x => x is IJumpEngine);
            if (environment.Channels.All(x => x <= engine.Range))
            {
                return new Result(Status.Success);
            }
            else
            {
                return new Result(Status.ShipIsLost);
            }
        }

        if ((Environment is SpaceEnvironment && ship.HasPulseEngine()) ||
               (Environment is NitrideParticlesEnvironment && ship.HasPulseEngineClassE()))
        {
            return new Result(Status.Success);
        }

        return new Result(Status.ShipIsDestroyed);
    }
}