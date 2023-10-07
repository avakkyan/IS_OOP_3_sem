namespace Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Interfaces;

public interface IBody
{
    public double HitPoints { get; }

    public void TakeDamage(double damage);
}