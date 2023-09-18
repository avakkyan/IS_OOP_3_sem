using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Asteroid : IObstacle
{
    private const int AsteroidDamage = 10;
    public Asteroid()
    {
        Damage = AsteroidDamage;
    }

    public int Damage { get; set; }
    public void Hit()
    {
        throw new System.NotImplementedException();
    }
}