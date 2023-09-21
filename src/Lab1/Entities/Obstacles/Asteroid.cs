using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Asteroid : Obstacle
{
    private const int AsteroidDamage = 10;
    public Asteroid()
    {
        Damage = AsteroidDamage;
    }
}