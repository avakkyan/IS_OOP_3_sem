﻿using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public class Asteroid : ISpaceObstacle
{
    public int Damage { get; init; } = 10;

    public void Hit(Ship ship)
    {
        if (ship.Deflector is not null && ship.Deflector.HitPoints > 0)
        {
            ship.Deflector.TakeDamage(Damage);
        }
        else
        {
            ship.Body.TakeDamage(Damage / ship.WeightSizeCoefficient);
        }
    }
}