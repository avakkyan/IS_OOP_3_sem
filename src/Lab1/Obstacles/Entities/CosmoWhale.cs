using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public class CosmoWhale : INitrideObstacle
{
    public int Damage { get; init; } = 400;
    public void Hit(Ship ship)
    {
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
            ship.Body.TakeDamage(ship.Body.HitPoints);
        }
    }
}