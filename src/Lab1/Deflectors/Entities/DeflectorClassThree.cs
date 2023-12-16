using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class DeflectorClassThree : IDeflector
{
    private const double ClassThreeHitPoints = 100;

    public DeflectorClassThree()
    {
        HitPoints = ClassThreeHitPoints;
    }

    public double HitPoints { get; private set; }
    public PhotonDeflector? PhotonDeflector { get; set; }

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }

    public void AddPhotonDeflector()
    {
        PhotonDeflector = new PhotonDeflector();
    }
}