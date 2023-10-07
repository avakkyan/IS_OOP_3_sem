using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityEnvironment : IEnvironment
{
    private readonly List<IHighDensityObstacle> _obstacles = new();
    private readonly List<double> _channels = new();

    public IReadOnlyCollection<double> Channels => _channels.AsReadOnly();
    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles.AsReadOnly();

    public void AddObstacle(IObstacle obstacle)
    {
        if (obstacle is IHighDensityObstacle highDensityObstacle)
        {
            _obstacles.Add(highDensityObstacle);
        }
    }

    public void AddChannel(double channel)
    {
        _channels.Add(channel);
    }
}