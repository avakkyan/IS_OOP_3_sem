using System;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

public class HddStorageWdBlue : IHddStorage, ICloneable
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
        HddConnection = _hhdWdBlueConnection;
    }

    public int StorageCapacity { get; private set; }
    public double StoragePowerConsumption { get; private set; }
    public int SpindleRotationSpeed { get; private set; }
    public StorageConnectionType HddConnection { get; private set; }

    public HddStorageWdBlue UpdateStorageCapacity(int storageCapacity)
    {
        var hddStorageWdBlue = (HddStorageWdBlue)Clone();
        hddStorageWdBlue.StorageCapacity = storageCapacity;
        return hddStorageWdBlue;
    }

    public HddStorageWdBlue UpdateStoragePowerConsumption(int storagePowerConsumption)
    {
        var hddStorageWdBlue = (HddStorageWdBlue)Clone();
        hddStorageWdBlue.StoragePowerConsumption = storagePowerConsumption;
        return hddStorageWdBlue;
    }

    public HddStorageWdBlue UpdateSpindleRotationSpeed(int spindleRotationSpeed)
    {
        var hddStorageWdBlue = (HddStorageWdBlue)Clone();
        hddStorageWdBlue.SpindleRotationSpeed = spindleRotationSpeed;
        return hddStorageWdBlue;
    }

    public HddStorageWdBlue UpdateHddConnetion(StorageConnectionType hddConnection)
    {
        var hddStorageWdBlue = (HddStorageWdBlue)Clone();
        hddStorageWdBlue.HddConnection = hddConnection;
        return hddStorageWdBlue;
    }

    public object Clone()
    {
        return new HddStorageWdBlue();
    }
}