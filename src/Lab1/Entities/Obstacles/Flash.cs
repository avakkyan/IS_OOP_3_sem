using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Flash : Obstacle
{
    private const int FlashDamage = 1000;
    public Flash()
    {
        Damage = FlashDamage;
    }

    public override void Hit(Ship ship)
    {
        if (ship is null)
        {
            throw new ArgumentException("Ship is null");
        }

        if (ship.Deflector?.PhotonDeflector is not null && ship.Deflector?.PhotonDeflector.HitPoints > 0)
        {
            ship.Deflector.PhotonDeflector.TakeDamage(Damage);
        }
        else
        {
            ship.KillCrew();
        }
    }
}