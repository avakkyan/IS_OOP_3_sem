using Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Entities;

public class BodyClass3 : IBody
{
    public double HitPoints { get; private set; } = 200;

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}