namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class PhotonDeflector
{
    public double HitPoints { get; private set; } = 3000;
    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}