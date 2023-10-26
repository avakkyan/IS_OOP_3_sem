using System;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiStandard;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Entities;

public class TpLinkArcherWiFiAdapter : IWiFiAdapter, ICloneable
{
    private const double _tpLinkArcherWiFiPciEVersion = 4.0;
    private const int _tpLinkArcherWiFiAdapterPower = 19;
    private const string _tpLinkArcherWiFiAdapteName = "TpLinkArcherWiFiAdapter";
    private TypeWiFiStandard _tpLinkArcherWiFiStandart = new TypeWiFiStandard480211N();

    public TpLinkArcherWiFiAdapter()
    {
        IsBluetoothModule = false;
        WiFiPciEVersion = _tpLinkArcherWiFiPciEVersion;
        PowerConsumption = _tpLinkArcherWiFiAdapterPower;
        WiFiAdapterStandart = _tpLinkArcherWiFiStandart;
        Name = _tpLinkArcherWiFiAdapteName;
    }

    public bool IsBluetoothModule { get; private set; }
    public double WiFiPciEVersion { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public TypeWiFiStandard WiFiAdapterStandart { get; private set; }

    public TpLinkArcherWiFiAdapter UpdateIsBluetoothModule(bool isBluetoothModule)
    {
        var tpLinkArcherT2uPlusWiFiAdapter = (TpLinkArcherWiFiAdapter)Clone();
        tpLinkArcherT2uPlusWiFiAdapter.IsBluetoothModule = isBluetoothModule;
        return tpLinkArcherT2uPlusWiFiAdapter;
    }

    public TpLinkArcherWiFiAdapter UpdateWiFiPciEVersion(double wiFiPciEVersion)
    {
        var tpLinkArcherT2uPlusWiFiAdapter = (TpLinkArcherWiFiAdapter)Clone();
        tpLinkArcherT2uPlusWiFiAdapter.WiFiPciEVersion = wiFiPciEVersion;

        return tpLinkArcherT2uPlusWiFiAdapter;
    }

    public TpLinkArcherWiFiAdapter UpdatePowerConsumption(int wiFiAdapterPower)
    {
        var tpLinkArcherT2uPlusWiFiAdapter = (TpLinkArcherWiFiAdapter)Clone();
        tpLinkArcherT2uPlusWiFiAdapter.PowerConsumption = wiFiAdapterPower;
        return tpLinkArcherT2uPlusWiFiAdapter;
    }

    public TpLinkArcherWiFiAdapter UpdateWiFiAdapterStandart(TypeWiFiStandard wiFiAdapterStandart)
    {
        var tpLinkArcherT2uPlusWiFiAdapter = (TpLinkArcherWiFiAdapter)Clone();
        tpLinkArcherT2uPlusWiFiAdapter.WiFiAdapterStandart = wiFiAdapterStandart;
        return tpLinkArcherT2uPlusWiFiAdapter;
    }

    public TpLinkArcherWiFiAdapter UpdateWiFiAdapterName(string name)
    {
        var tpLinkArcherT2uPlusWiFiAdapter = (TpLinkArcherWiFiAdapter)Clone();
        tpLinkArcherT2uPlusWiFiAdapter.Name = name;
        return tpLinkArcherT2uPlusWiFiAdapter;
    }

    public object Clone()
    {
        return new TpLinkArcherWiFiAdapter();
    }
}