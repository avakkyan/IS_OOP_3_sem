namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public sealed class FuelExchange
{
    private static FuelExchange? _fuelExchange;
    private FuelExchange()
    {
    }

    public static FuelExchange GetFuelExchange()
    {
        return _fuelExchange ??= new FuelExchange();
    }
}