namespace Itmo.ObjectOrientedProgramming.Lab1.ShipBodies.Interfaces;

public interface IBody
{
    double HitPoints { get; }

    void TakeDamage(double damage);
}