namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class PhotonDeflector
{
    private const double PhotonHitPoints = 3000;

    public PhotonDeflector()
    {
        HitPoints = PhotonHitPoints;
    }

    public double HitPoints { get; private set; }
    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}