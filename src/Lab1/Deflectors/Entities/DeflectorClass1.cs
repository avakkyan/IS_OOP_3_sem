using System;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class DeflectorClass1 : IDeflector
{
    public double HitPoints { get; private set; } = 10;
    public PhotonDeflector? PhotonDeflector { get; private set; }

    public void TakeDamage(double damage)
    {
        HitPoints -= damage;
    }

    public void AddPhotonDeflector()
    {
        PhotonDeflector = new PhotonDeflector();
        Console.WriteLine("zalupa");
    }
}