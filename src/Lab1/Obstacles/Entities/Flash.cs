using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public class Flash : IHighDensityObstacle
{
    private const double FlashDamage = 1000;
    public Flash()
    {
        Damage = FlashDamage;
    }

    public double Damage { get; }
    public void Hit(Ship ship)
    {
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