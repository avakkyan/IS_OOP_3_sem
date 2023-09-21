using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts;

public class Deflector
{
    private const double HitPoints1 = 10;
    private const double HitPoints2 = 50;
    private const double HitPoints3 = 200;
    public Deflector(DeflectorClass deflectorClass)
    {
        HitPoints = deflectorClass switch
        {
            DeflectorClass.Class1 => HitPoints1,
            DeflectorClass.Class2 => HitPoints2,
            DeflectorClass.Class3 => HitPoints3,
            _ => throw new ArgumentException("Wrong deflector class"),
        };
    }

    public double HitPoints { get; private set; }
    public PhotonDeflector? PhotonDeflector { get; private set; }

    public void AddPhotonDeflector()
    {
        PhotonDeflector = new PhotonDeflector();
    }

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }
}