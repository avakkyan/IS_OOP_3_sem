namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public sealed class FuelExchange
{
    private const double Plasma = 10;
    private const double Graviton = 15;

    // private static FuelExchange? _fuelExchange;
    private FuelExchange()
    {
        PlasmaCost = Plasma;
        GravitonCost = Graviton;
    }

    public double PlasmaCost { get; set; }
    public double GravitonCost { get; set; }

    // public static FuelExchange GetFuelExchange()
    // {
    //     return _fuelExchange ??= new FuelExchange();
    // }
}