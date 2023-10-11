using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;

public interface IEnvironment
{
    IReadOnlyCollection<IObstacle> Obstacles { get; }
}