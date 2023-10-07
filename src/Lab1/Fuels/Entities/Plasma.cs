using Itmo.ObjectOrientedProgramming.Lab1.Fuels.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab1.Fuels.Entities;

public class Plasma : IFuel
{
    public double Amount { get; private set; }

    public void Add(double amount)
    {
        if (amount < 0)
        {
            throw new SpaceException("Wrong fuel amount");
        }

        Amount += amount;
    }

    public void Reduce(double amount)
    {
        if (amount < 0)
        {
            throw new SpaceException("Wrong fuel amount");
        }

        Amount -= amount;
    }
}