namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts;

public class PhotonDeflector
{
    private const double InitialHitPoints = 3000;
    public PhotonDeflector()
    {
        HitPoints = InitialHitPoints;
    }

    public double HitPoints { get; private set; }
    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}