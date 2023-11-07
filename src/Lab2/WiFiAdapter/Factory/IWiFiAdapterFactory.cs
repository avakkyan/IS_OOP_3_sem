using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiStandard;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Factory;

public interface IWiFiAdapterFactory
{
    IWiFiAdapter CreateWiFiAdapter(
        bool isBluetoothModule,
        double pciVersion,
        int powerConsumption,
        string name,
        TypeWiFiStandard standard);
}