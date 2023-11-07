using System;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

public class HddStorage : IHddStorage, ICloneable
{
    public HddStorage(
        int capacity,
        double powerConsumption,
        int spindleRotationSpeed,
        string name,
        int hddConnection)
    {
        StorageCapacity = capacity;
        StoragePowerConsumption = powerConsumption;
        SpindleRotationSpeed = spindleRotationSpeed;
        HddConnection = hddConnection;
        Name = name;
    }

    public int StorageCapacity { get; private set; }
    public double StoragePowerConsumption { get; private set; }
    public int SpindleRotationSpeed { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public int HddConnection { get; private set; }

    public HddStorage UpdateStorageCapacity(int storageCapacity)
    {
        var hddStorage = (HddStorage)Clone();
        hddStorage.StorageCapacity = storageCapacity;
        return hddStorage;
    }

    public HddStorage UpdateStoragePowerConsumption(int storagePowerConsumption)
    {
        var hddStorage = (HddStorage)Clone();
        hddStorage.StoragePowerConsumption = storagePowerConsumption;
        return hddStorage;
    }

    public HddStorage UpdateSpindleRotationSpeed(int spindleRotationSpeed)
    {
        var hddStorage = (HddStorage)Clone();
        hddStorage.SpindleRotationSpeed = spindleRotationSpeed;
        return hddStorage;
    }

    public HddStorage UpdateHddConnetion(int hddConnection)
    {
        var hddStorage = (HddStorage)Clone();
        hddStorage.HddConnection = hddConnection;
        return hddStorage;
    }

    public HddStorage UpdatePowerConsumption(int powerConsumption)
    {
        var hddStorage = (HddStorage)Clone();
        hddStorage.PowerConsumption = powerConsumption;
        return hddStorage;
    }

    public object Clone()
    {
        return new HddStorage(
            StorageCapacity,
            StoragePowerConsumption,
            SpindleRotationSpeed,
            Name,
            HddConnection);
    }
}