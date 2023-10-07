using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;

public interface IEnvironment
{
    public IReadOnlyCollection<IObstacle> Obstacles { get; }
    public void AddObstacle(IObstacle obstacle);
}