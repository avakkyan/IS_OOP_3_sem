using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

public class SsdStorageApacerPanther : ISsdStorage
{
    private int _ssdApacerPantherCapacity = 480;
    private double _ssdApacerPantherPowerConsumption = 6.8;
    private int _ssdApacerPantherMaximumOperatingSpeed = 241;
    private StorageConnectionType _ssdApacerPantherConnection = new SataConnection();

    public SsdStorageApacerPanther()
    {
        StorageCapacity = _ssdApacerPantherCapacity;
        StoragePowerConsumption = _ssdApacerPantherPowerConsumption;
        MaximumOperatingSpeed = _ssdApacerPantherMaximumOperatingSpeed;
        SsdConnetion = _ssdApacerPantherConnection;
    }

    public int StorageCapacity { get; }
    public double StoragePowerConsumption { get; }
    public int MaximumOperatingSpeed { get; }
    public StorageConnectionType SsdConnetion { get; }
}