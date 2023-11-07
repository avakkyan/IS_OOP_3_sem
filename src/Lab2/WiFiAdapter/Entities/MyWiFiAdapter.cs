using System;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiStandard;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Entities;

public class MyWiFiAdapter : IWiFiAdapter, ICloneable
{
    public MyWiFiAdapter(
        bool isBluetoothModule,
        double pciVersion,
        int powerConsumption,
        string name,
        TypeWiFiStandard standard)
    {
        IsBluetoothModule = isBluetoothModule;
        WiFiPciEVersion = pciVersion;
        PowerConsumption = powerConsumption;
        WiFiAdapterStandard = standard;
        Name = name;
    }

    public bool IsBluetoothModule { get; private set; }
    public double WiFiPciEVersion { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public TypeWiFiStandard WiFiAdapterStandard { get; private set; }

    public MyWiFiAdapter UpdateIsBluetoothModule(bool isBluetoothModule)
    {
        var wiFiAdapter = (MyWiFiAdapter)Clone();
        wiFiAdapter.IsBluetoothModule = isBluetoothModule;
        return wiFiAdapter;
    }

    public MyWiFiAdapter UpdateWiFiPciEVersion(double wiFiPciEVersion)
    {
        var wiFiAdapter = (MyWiFiAdapter)Clone();
        wiFiAdapter.WiFiPciEVersion = wiFiPciEVersion;
        return wiFiAdapter;
    }

    public MyWiFiAdapter UpdateWiFiAdapterPower(int wiFiAdapterPower)
    {
        var wiFiAdapter = (MyWiFiAdapter)Clone();
        wiFiAdapter.PowerConsumption = wiFiAdapterPower;
        return wiFiAdapter;
    }

    public MyWiFiAdapter UpdateWiFiAdapterStandart(TypeWiFiStandard wiFiAdapterStandart)
    {
        var wiFiAdapter = (MyWiFiAdapter)Clone();
        wiFiAdapter.WiFiAdapterStandard = wiFiAdapterStandart;
        return wiFiAdapter;
    }

    public MyWiFiAdapter UpdateWiFiAdapterName(string name)
    {
        var wiFiAdapter = (MyWiFiAdapter)Clone();
        wiFiAdapter.Name = name;
        return wiFiAdapter;
    }

    public object Clone()
    {
        return new MyWiFiAdapter(
            IsBluetoothModule,
            WiFiPciEVersion,
            PowerConsumption,
            Name,
            WiFiAdapterStandard);
    }
}