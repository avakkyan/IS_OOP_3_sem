using System;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

public class SsdStorage : ISsdStorage, ICloneable
{
    public SsdStorage(
        int capacity,
        double powerConsumption,
        int maximumOperatingSpeed,
        int? connectionPci,
        string name,
        int? connectionSata)
    {
        StorageCapacity = capacity;
        StoragePowerConsumption = powerConsumption;
        MaximumOperatingSpeed = maximumOperatingSpeed;
        SsdConnectionSata = connectionSata;
        SsdConnectionPci = connectionPci;
        Name = name;
    }

    public int StorageCapacity { get; private set; }
    public double StoragePowerConsumption { get; private set; }
    public int MaximumOperatingSpeed { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public int? SsdConnectionPci { get; private set; }
    public int? SsdConnectionSata { get; private set; }

    public SsdStorage UpdateStorageCapacity(int storageCapacity)
    {
        var ssdStorage = (SsdStorage)Clone();
        ssdStorage.StorageCapacity = storageCapacity;
        return ssdStorage;
    }

    public SsdStorage UpdateStoragePowerConsumption(int storagePowerConsumption)
    {
        var ssdStorage = (SsdStorage)Clone();
        ssdStorage.StoragePowerConsumption = storagePowerConsumption;
        return ssdStorage;
    }

    public SsdStorage UpdateMaximumOperatingSpeed(int maximumOperatingSpeed)
    {
        var ssdStorage = (SsdStorage)Clone();
        ssdStorage.MaximumOperatingSpeed = maximumOperatingSpeed;
        return ssdStorage;
    }

    public SsdStorage UpdateStorageConnectionPci(int ssdConnectionPci)
    {
        var ssdStorage = (SsdStorage)Clone();
        ssdStorage.SsdConnectionPci = ssdConnectionPci;
        return ssdStorage;
    }

    public SsdStorage UpdatePowerConsumption(int powerConsumption)
    {
        var ssdStorage = (SsdStorage)Clone();
        ssdStorage.PowerConsumption = powerConsumption;
        return ssdStorage;
    }

    public SsdStorage UpdateStorageConnectionSata(int ssdSataConnection)
    {
        var ssdStorage = (SsdStorage)Clone();
        ssdStorage.SsdConnectionSata = ssdSataConnection;
        return ssdStorage;
    }

    public SsdStorage Update(string name)
    {
        var ssdStorage = (SsdStorage)Clone();
        ssdStorage.Name = name;
        return ssdStorage;
    }

    public object Clone()
    {
        return new SsdStorage(
            StorageCapacity,
            StoragePowerConsumption,
            MaximumOperatingSpeed,
            SsdConnectionPci,
            Name,
            SsdConnectionSata);
    }
}