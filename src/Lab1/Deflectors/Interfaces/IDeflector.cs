using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Interfaces;

public interface IDeflector
{
    double HitPoints { get; }
    PhotonDeflector? PhotonDeflector { get; }
    void TakeDamage(double damage);
    void AddPhotonDeflector();
}