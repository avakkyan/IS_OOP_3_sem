namespace Itmo.ObjectOrientedProgramming.Lab1.Fuels;

public sealed class FuelExchange
{
    private const double Plasma = 10;
    private const double Graviton = 15;

    private static FuelExchange? _fuelExchange;
    private FuelExchange()
    {
        PlasmaCost = Plasma;
        GravitonCost = Graviton;
    }

    public static FuelExchange GetFuelExchange => _fuelExchange ??= new FuelExchange();
    public double PlasmaCost { get; }
    public double GravitonCost { get; }
}