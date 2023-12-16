using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiStandard;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Factory;

public class WiFiAdapterFactory : IWiFiAdapterFactory
{
    public IWiFiAdapter CreateWiFiAdapter(
        bool isBluetoothModule,
        double pciVersion,
        int powerConsumption,
        string name,
        TypeWiFiStandard standard)
    {
        return new MyWiFiAdapter(
            isBluetoothModule,
            pciVersion,
            powerConsumption,
            name,
            standard);
    }
}