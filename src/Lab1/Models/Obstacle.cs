using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public abstract class Obstacle
{
    public int Damage { get; init; }

    public virtual void Hit(Ship ship)
    {
        if (ship is null)
        {
            throw new ArgumentException("Ship is null");
        }

        if (ship.Deflector is not null && ship.Deflector.HitPoints > 0)
        {
            ship.Deflector.TakeDamage(Damage);
        }
        else
        {
            ship.Body?.TakeDamage(Damage / ship.WeightSizeCoefficient);
        }
    }
}