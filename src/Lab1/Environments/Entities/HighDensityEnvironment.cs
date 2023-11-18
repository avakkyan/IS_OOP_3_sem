using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityEnvironment : IEnvironment
{
    private readonly List<IHighDensityObstacle> _obstacles;
    private readonly List<double> _channels;

    public HighDensityEnvironment()
    {
        _obstacles = new List<IHighDensityObstacle>();
        _channels = new List<double>();
    }

    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles;
    public IReadOnlyCollection<double> Channels => _channels;

    public void AddObstacle(IHighDensityObstacle obstacle)
    {
        _obstacles.Add(obstacle);
    }

    public void AddChannel(double channel)
    {
        _channels.Add(channel);
    }
}