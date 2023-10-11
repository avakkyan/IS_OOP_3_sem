using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NitrideParticlesEnvironment : IEnvironment
{
    private readonly List<INitrideObstacle> _obstacles;

    public NitrideParticlesEnvironment()
    {
        _obstacles = new List<INitrideObstacle>();
    }

    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles;

    public void AddObstacle(INitrideObstacle obstacle)
    {
        _obstacles.Add(obstacle);
    }
}