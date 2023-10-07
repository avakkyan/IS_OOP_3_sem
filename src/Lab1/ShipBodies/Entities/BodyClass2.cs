using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Entities;

public class BodyClass2 : IBody
{
    public double HitPoints { get; private set; } = 50;

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}