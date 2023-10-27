using System;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

public class HddStorageWdBlue : IHddStorage, ICloneable
{
    private const int _hhdWdBlueCapacity = 1000;
    private const double _hhdWdBluePowerConsumption = 6.8;
    private const int _hhdWdBlueSpindleRotationSpeed = 7200;
    private const string _hhdWdBlueName = "HddStorageWdBlue";
    private int _hhdWdBlueConnection = 4;

    public HddStorageWdBlue()
    {
        StorageCapacity = _hhdWdBlueCapacity;
        StoragePowerConsumption = _hhdWdBluePowerConsumption;
        SpindleRotationSpeed = _hhdWdBlueSpindleRotationSpeed;
        HddConnection = _hhdWdBlueConnection;
        Name = _hhdWdBlueName;
    }

    public int StorageCapacity { get; private set; }
    public double StoragePowerConsumption { get; private set; }
    public int SpindleRotationSpeed { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public int HddConnection { get; private set; }

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

    public HddStorageWdBlue UpdateHddConnetion(int hddConnection)
    {
        var hddStorageWdBlue = (HddStorageWdBlue)Clone();
        hddStorageWdBlue.HddConnection = hddConnection;
        return hddStorageWdBlue;
    }

    public HddStorageWdBlue UpdatePowerConsumption(int powerConsumption)
    {
        var hddStorageWdBlue = (HddStorageWdBlue)Clone();
        hddStorageWdBlue.PowerConsumption = powerConsumption;
        return hddStorageWdBlue;
    }

    public object Clone()
    {
        return new HddStorageWdBlue();
    }
}