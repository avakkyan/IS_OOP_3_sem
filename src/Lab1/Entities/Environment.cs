using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Environment
{
    private List<Tuple<EnvironmentType, Type>> _combinations = new()
    {
        new(EnvironmentType.Space, typeof(Asteroid)),
        new(EnvironmentType.Space, typeof(Meteorite)),
        new(EnvironmentType.NitrideParticles, typeof(CosmoWhale)),
        new(EnvironmentType.HighDensity, typeof(Flash)),
    };
    private List<IObstacle> _obstacles;

    public Environment(EnvironmentType type)
    {
        Type = type;
        _obstacles = new List<IObstacle>();
    }

    public Environment(EnvironmentType type, IReadOnlyCollection<IObstacle> obstacles)
    {
        if (obstacles is null)
        {
            throw new ArgumentException("Obstacles is null");
        }

        _obstacles = new List<IObstacle>();
        foreach (IObstacle obstacle in obstacles)
        {
            AddObstacle(obstacle);
        }

        Type = type;
    }

    public EnvironmentType Type { get; set; }
    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles.AsReadOnly();

    public IObstacle AddObstacle(IObstacle obstacle)
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
}