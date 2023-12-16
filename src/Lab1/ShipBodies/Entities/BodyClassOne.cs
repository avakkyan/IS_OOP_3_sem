using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Entities;

public class BodyClassOne : IBody
{
    private const double ClassOneHitPoints = 15;
    public BodyClassOne()
    {
        HitPoints = ClassOneHitPoints;
    }

    public double HitPoints { get; private set; }

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}