using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class CosmoWhale : Obstacle
{
    private const int CosmoWhaleDamage = 400;
    public CosmoWhale()
    {
        Damage = CosmoWhaleDamage;
    }

    public override void Hit(Ship ship)
    {
        if (ship is null)
        {
            throw new ArgumentException("Ship is null");
        }

        if (ship.HasAntiNitrineEmitter)
        {
            return;
        }

        if (ship.Deflector is not null)
        {
            ship.DestroyDeflector();
        }
        else
        {
            ship.Body?.TakeDamage(ship.Body.HitPoints);
        }
    }
}