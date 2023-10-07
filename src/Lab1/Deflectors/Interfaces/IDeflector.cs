using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Interfaces;

public interface IDeflector
{
    public double HitPoints { get; }
    public PhotonDeflector? PhotonDeflector { get; }
    public void TakeDamage(double damage);
    public void AddPhotonDeflector();
}