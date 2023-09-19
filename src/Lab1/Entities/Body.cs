using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Body
{
    private const int HitPoints1 = 10;
    private const int HitPoints2 = 50;
    private const int HitPoints3 = 200;
    public Body(BodyClass bodyClass)
    {
        HitPoints = bodyClass switch
        {
            BodyClass.Class1 => HitPoints1,
            BodyClass.Class2 => HitPoints2,
            BodyClass.Class3 => HitPoints3,
            _ => throw new ArgumentException("Wrong body class"),
        };
    }

    public int HitPoints { get; set; }
}