using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Meteorite : Obstacle
{
    private const int MeteoriteDamage = 15;

    public Meteorite()
    {
        Damage = MeteoriteDamage;
    }
}