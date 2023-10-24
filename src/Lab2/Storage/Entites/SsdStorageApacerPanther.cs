using System;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

public class SsdStorageApacerPanther : ISsdStorage, ICloneable
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
        SsdConnection = _ssdApacerPantherConnection;
    }

    public int StorageCapacity { get; private set; }
    public double StoragePowerConsumption { get; private set; }
    public int MaximumOperatingSpeed { get; private set; }
    public StorageConnectionType SsdConnection { get; private set; }

    public SsdStorageApacerPanther UpdateStorageCapacity(int storageCapacity)
    {
        var ssdStorageApacerPanther = (SsdStorageApacerPanther)Clone();
        ssdStorageApacerPanther.StorageCapacity = storageCapacity;
        return ssdStorageApacerPanther;
    }

    public SsdStorageApacerPanther UpdateStoragePowerConsumption(int storagePowerConsumption)
    {
        var ssdStorageApacerPanther = (SsdStorageApacerPanther)Clone();
        ssdStorageApacerPanther.StoragePowerConsumption = storagePowerConsumption;
        return ssdStorageApacerPanther;
    }

    public SsdStorageApacerPanther UpdateMaximumOperatingSpeed(int maximumOperatingSpeed)
    {
        var ssdStorageApacerPanther = (SsdStorageApacerPanther)Clone();
        ssdStorageApacerPanther.MaximumOperatingSpeed = maximumOperatingSpeed;
        return ssdStorageApacerPanther;
    }

    public SsdStorageApacerPanther UpdateStorageCapacity(StorageConnectionType ssdConnection)
    {
        var ssdStorageApacerPanther = (SsdStorageApacerPanther)Clone();
        ssdStorageApacerPanther.SsdConnection = ssdConnection;
        return ssdStorageApacerPanther;
    }

    public object Clone()
    {
        return new SsdStorageApacerPanther();
    }
}