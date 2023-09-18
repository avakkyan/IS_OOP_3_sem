using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Meteorite : IObstacle
{
    private const int MeteoriteDamage = 15;

    public Meteorite()
    {
        Damage = MeteoriteDamage;
    }

    public int Damage { get; set; }
    public void Hit()
    {
        throw new System.NotImplementedException();
    }
}