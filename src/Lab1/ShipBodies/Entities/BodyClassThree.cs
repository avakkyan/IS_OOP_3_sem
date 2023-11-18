using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Entities;

public class BodyClassThree : IBody
{
    private const double ClassThreeHitPoints = 200;
    public BodyClassThree()
    {
        HitPoints = ClassThreeHitPoints;
    }

    public double HitPoints { get; private set; }

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}