using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class Fuel
{
    public Fuel(FuelType type)
    {
        Type = type;
        Amount = 0;
    }

    public FuelType Type { get; }
    public double Amount { get; set; }
}