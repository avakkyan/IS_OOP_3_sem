namespace Itmo.ObjectOrientedProgramming.Lab1.Fuels.Interfaces;

public interface IFuel
{
    double Amount { get; }
    void Add(double amount);
    void Reduce(double amount);
}