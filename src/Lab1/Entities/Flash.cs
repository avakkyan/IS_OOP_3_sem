using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Flash : IObstacle
{
    private const int FlashDamage = 1000;
    public Flash()
    {
        Damage = FlashDamage;
    }

    public int Damage { get; set; }

    public void Hit()
    {
        throw new System.NotImplementedException();
    }
}