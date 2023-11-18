using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public class CosmoWhale : INitrideObstacle
{
    private const double CosmoWhaleDamage = 400;
    public CosmoWhale()
    {
        Damage = CosmoWhaleDamage;
    }

    public double Damage { get; }
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