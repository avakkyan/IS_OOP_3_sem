using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class DeflectorClassOne : IDeflector
{
    private const double ClassOneHitPoints = 10;

    public DeflectorClassOne()
    {
        HitPoints = ClassOneHitPoints;
    }

    public double HitPoints { get; private set; }
    public PhotonDeflector? PhotonDeflector { get; private set; }

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }

    public void AddPhotonDeflector()
    {
        PhotonDeflector = new PhotonDeflector();
    }
}