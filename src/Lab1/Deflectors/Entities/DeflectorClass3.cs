using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class DeflectorClass3 : IDeflector
{
    public double HitPoints { get; private set; } = 200;
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