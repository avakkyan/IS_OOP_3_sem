namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class Engine
{
    private const double InitialSpeed = 10;
    protected Engine()
    {
        Speed = InitialSpeed;
    }

    public EngineType Type { get; set; }
    protected EngineClass Class { get; init; }
    protected double Speed { get; }
    protected double FuelConsumption { get; init; }
}