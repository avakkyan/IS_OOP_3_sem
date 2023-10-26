using System;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiStandard;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Entities;

public class DexpWiFiAdapter : IWiFiAdapter, ICloneable
{
    private const double _dexpWiFiPciVersion = 4.0;
    private const int _dexpWiFiAdapterPower = 20;
    private const string _dexpWiFiAdapterName = "DexpWiFiAdapter";
    private TypeWiFiStandard _dexpWiFiAdapterStandart = new TypeWiFiStandard480211N();

    public DexpWiFiAdapter()
    {
        IsBluetoothModule = false;
        WiFiPciEVersion = _dexpWiFiPciVersion;
        PowerConsumption = _dexpWiFiAdapterPower;
        WiFiAdapterStandart = _dexpWiFiAdapterStandart;
        Name = _dexpWiFiAdapterName;
    }

    public bool IsBluetoothModule { get; private set; }
    public double WiFiPciEVersion { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public TypeWiFiStandard WiFiAdapterStandart { get; private set; }

    public DexpWiFiAdapter UpdateIsBluetoothModule(bool isBluetoothModule)
    {
        var dexp601WiFiAdapter = (DexpWiFiAdapter)Clone();
        dexp601WiFiAdapter.IsBluetoothModule = isBluetoothModule;
        return dexp601WiFiAdapter;
    }

    public DexpWiFiAdapter UpdateWiFiPciEVersion(double wiFiPciEVersion)
    {
        var dexp601WiFiAdapter = (DexpWiFiAdapter)Clone();
        dexp601WiFiAdapter.WiFiPciEVersion = wiFiPciEVersion;

        return dexp601WiFiAdapter;
    }

    public DexpWiFiAdapter UpdateWiFiAdapterPower(int wiFiAdapterPower)
    {
        var dexp601WiFiAdapter = (DexpWiFiAdapter)Clone();
        dexp601WiFiAdapter.PowerConsumption = wiFiAdapterPower;
        return dexp601WiFiAdapter;
    }

    public DexpWiFiAdapter UpdateWiFiAdapterStandart(TypeWiFiStandard wiFiAdapterStandart)
    {
        var dexp601WiFiAdapter = (DexpWiFiAdapter)Clone();
        dexp601WiFiAdapter.WiFiAdapterStandart = wiFiAdapterStandart;
        return dexp601WiFiAdapter;
    }

    public DexpWiFiAdapter UpdateWiFiAdapterName(string name)
    {
        var dexp601WiFiAdapter = (DexpWiFiAdapter)Clone();
        dexp601WiFiAdapter.Name = name;
        return dexp601WiFiAdapter;
    }

    public object Clone()
    {
        return new DexpWiFiAdapter();
    }
}