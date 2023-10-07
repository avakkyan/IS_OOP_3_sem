namespace Itmo.ObjectOrientedProgramming.Lab1.Fuels.Interfaces;

public interface IFuel
{
    public double Amount { get; }
    public void Add(double amount);
    public void Reduce(double amount);
}