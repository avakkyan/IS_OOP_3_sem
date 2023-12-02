using Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;

public class HddStorageFactory : IStorageFatory
{
    private int _spindleRotationSpeed;
    private int _hddConnection;

    public HddStorageFactory(int spindleRotationSpeed, int hddConnection)
    {
        _spindleRotationSpeed = spindleRotationSpeed;
        _hddConnection = hddConnection;
    }

    public IStorage CreateStorage(
        int capacity,
        double powerConsumption,
        string name)
    {
        return new HddStorage(
             capacity,
             powerConsumption,
             _spindleRotationSpeed,
             name,
             _hddConnection);
    }
}