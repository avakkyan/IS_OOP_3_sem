using Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;

public class SsdStorageFacroty : IStorageFatory
{
    private int _maximumOperatingSpeed;
    private int? _connectionPci;
    private int? _connectionSata;

    public SsdStorageFacroty(int maximumOperatingSpeed, int connectionPci, int? connectionSata)
    {
        _maximumOperatingSpeed = maximumOperatingSpeed;
        _connectionPci = connectionPci;
        _connectionSata = connectionSata;
    }

    public IStorage CreateStorage(
        int capacity,
        double powerConsumption,
        string name)
    {
        return new SsdStorage(
            capacity,
            powerConsumption,
            _maximumOperatingSpeed,
            _connectionPci,
            name,
            _connectionSata);
    }
}