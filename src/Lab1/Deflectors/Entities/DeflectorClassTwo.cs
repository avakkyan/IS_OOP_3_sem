using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class DeflectorClassTwo : IDeflector
{
    private const double ClassTwoHitPoints = 50;

    public DeflectorClassTwo()
    {
        HitPoints = ClassTwoHitPoints;
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