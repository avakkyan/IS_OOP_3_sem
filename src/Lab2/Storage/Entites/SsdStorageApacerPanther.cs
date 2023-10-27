using System;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

public class SsdStorageApacerPanther : ISsdStorage, ICloneable
{
    private const int _ssdApacerPantherCapacity = 480;
    private const double _ssdApacerPantherPowerConsumption = 6.8;
    private const int _ssdApacerPantherMaximumOperatingSpeed = 241;
    private const string _ssdApacerPantherName = "SsdStorageApacerPanther";
    private int? _ssdApacerPantherConnectionSata = 4;

    public SsdStorageApacerPanther()
    {
        StorageCapacity = _ssdApacerPantherCapacity;
        StoragePowerConsumption = _ssdApacerPantherPowerConsumption;
        MaximumOperatingSpeed = _ssdApacerPantherMaximumOperatingSpeed;
        SsdConnectionSata = _ssdApacerPantherConnectionSata;
        Name = _ssdApacerPantherName;
    }

    public int StorageCapacity { get; private set; }
    public double StoragePowerConsumption { get; private set; }
    public int MaximumOperatingSpeed { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public int? SsdConnectionPci { get; private set; }
    public int? SsdConnectionSata { get; private set; }

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

    public SsdStorageApacerPanther UpdateStorageConnectionPci(int ssdConnectionPci)
    {
        var ssdStorageApacerPanther = (SsdStorageApacerPanther)Clone();
        ssdStorageApacerPanther.SsdConnectionPci = ssdConnectionPci;
        return ssdStorageApacerPanther;
    }

    public SsdStorageApacerPanther UpdatePowerConsumption(int powerConsumption)
    {
        var ssdStorageApacerPanther = (SsdStorageApacerPanther)Clone();
        ssdStorageApacerPanther.PowerConsumption = powerConsumption;
        return ssdStorageApacerPanther;
    }

    public SsdStorageApacerPanther UpdateStorageConnectionSata(int ssdSataConnection)
    {
        var ssdStorageApacerPanther = (SsdStorageApacerPanther)Clone();
        ssdStorageApacerPanther.SsdConnectionSata = ssdSataConnection;
        return ssdStorageApacerPanther;
    }

    public SsdStorageApacerPanther Update(string name)
    {
        var ssdStorageApacerPanther = (SsdStorageApacerPanther)Clone();
        ssdStorageApacerPanther.Name = name;
        return ssdStorageApacerPanther;
    }

    public object Clone()
    {
        return new SsdStorageApacerPanther();
    }
}