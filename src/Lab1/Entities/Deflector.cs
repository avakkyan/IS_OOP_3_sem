using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Deflector
{
    private const int HitPoints1 = 10;
    private const int HitPoints2 = 50;
    private const int HitPoints3 = 200;
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

    public int HitPoints { get; set; }
    public PhotonDeflector? PhotonDeflector { get; private set; }

    public void AddPhotonDeflector()
    {
        PhotonDeflector = new PhotonDeflector();
    }
}