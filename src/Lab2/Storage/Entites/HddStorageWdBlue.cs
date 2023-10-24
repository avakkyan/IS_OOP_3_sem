using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

public class HddStorageWdBlue : IHddStorage
{
    private static int _hhdWdBlueCapacity = 1000;
    private static double _hhdWdBluePowerConsumption = 6.8;
    private static int _hhdWdBlueSpindleRotationSpeed = 7200;
    private StorageConnectionType _hhdWdBlueConnection = new SataConnection();

    public HddStorageWdBlue()
    {
        StorageCapacity = _hhdWdBlueCapacity;
        StoragePowerConsumption = _hhdWdBluePowerConsumption;
        SpindleRotationSpeed = _hhdWdBlueSpindleRotationSpeed;
        HddConnetion = _hhdWdBlueConnection;
    }

    public int StorageCapacity { get; }
    public double StoragePowerConsumption { get; }
    public int SpindleRotationSpeed { get; }
    public StorageConnectionType HddConnetion { get; }
}