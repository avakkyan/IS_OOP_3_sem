// using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public class Flash : IHighDensityObstacle
{
    public int Damage { get; } = 1000;
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