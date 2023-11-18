using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class SpaceEnvironment : IEnvironment
{
    private readonly List<ISpaceObstacle> _obstacles;

    public SpaceEnvironment()
    {
        _obstacles = new List<ISpaceObstacle>();
    }

    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles;

    public void AddObstacle(ISpaceObstacle obstacle)
    {
        _obstacles.Add(obstacle);
    }
}