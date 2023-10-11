using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Entities;

public class BodyClassTwo : IBody
{
    private const double ClassTwoHitPoints = 50;
    public BodyClassTwo()
    {
        HitPoints = ClassTwoHitPoints;
    }

    public double HitPoints { get; private set; }

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}