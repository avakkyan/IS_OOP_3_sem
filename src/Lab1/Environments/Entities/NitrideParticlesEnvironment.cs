using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NitrideParticlesEnvironment : IEnvironment
{
    private readonly List<INitrideObstacle> _obstacles = new();

    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles.AsReadOnly();

    public void AddObstacle(IObstacle obstacle)
    {
        if (obstacle is INitrideObstacle nitrideObstacle)
        {
            _obstacles.Add(nitrideObstacle);
        }
    }
}