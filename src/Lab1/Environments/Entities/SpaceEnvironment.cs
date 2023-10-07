using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class SpaceEnvironment : IEnvironment
{
    private readonly List<ISpaceObstacle> _obstacles = new();
    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles.AsReadOnly();

    public void AddObstacle(IObstacle obstacle)
    {
        if (obstacle is ISpaceObstacle spaceObstacle)
        {
            _obstacles.Add(spaceObstacle);
        }
    }
}