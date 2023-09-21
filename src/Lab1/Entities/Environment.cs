using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Environment
{
    private readonly List<Tuple<EnvironmentType, Type>> _combinations = new()
    {
        new(EnvironmentType.Space, typeof(Asteroid)),
        new(EnvironmentType.Space, typeof(Meteorite)),
        new(EnvironmentType.NitrideParticles, typeof(CosmoWhale)),
        new(EnvironmentType.HighDensity, typeof(Flash)),
    };
    private readonly List<Obstacle> _obstacles = new();
    private readonly List<double> _channels = new();

    public Environment(EnvironmentType type)
    {
        Type = type;
    }

    public Environment(EnvironmentType type, IReadOnlyCollection<Obstacle> obstacles)
    {
        if (type == EnvironmentType.HighDensity)
        {
            throw new ArgumentException("High density environment must have channels");
        }

        if (obstacles is null)
        {
            throw new ArgumentException("Obstacles is null");
        }

        foreach (Obstacle obstacle in obstacles)
        {
            AddObstacle(obstacle);
        }

        Type = type;
    }

    public Environment(
        EnvironmentType type,
        IReadOnlyCollection<Obstacle> obstacles,
        IReadOnlyCollection<double> channels)
    {
        if (type != EnvironmentType.HighDensity)
        {
            throw new ArgumentException("Environment type doesn't have channels");
        }

        if (obstacles is null)
        {
            throw new ArgumentException("Obstacles is null");
        }

        if (channels is null)
        {
            throw new ArgumentException("Channels is null");
        }

        foreach (Obstacle obstacle in obstacles)
        {
            AddObstacle(obstacle);
        }

        foreach (double channel in channels)
        {
            AddChannel(channel);
        }

        Type = type;
    }

    public EnvironmentType Type { get; }
    public IReadOnlyCollection<Obstacle> Obstacles => _obstacles.AsReadOnly();

    public IReadOnlyCollection<double>? Channels => Type == EnvironmentType.HighDensity ? _channels.AsReadOnly() : null;

    public Obstacle AddObstacle(Obstacle obstacle)
    {
        if (obstacle is null)
        {
            throw new ArgumentException("Obstacle is null");
        }

        var tuple = new Tuple<EnvironmentType, Type>(Type, obstacle.GetType());
        if (!_combinations.Contains(tuple))
        {
            throw new ArgumentException("Invalid Combination");
        }

        _obstacles.Add(obstacle);
        return obstacle;
    }

    public void AddChannel(double channel)
    {
        _channels.Add(channel);
    }
}