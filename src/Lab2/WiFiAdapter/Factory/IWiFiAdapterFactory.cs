using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Factory;

public interface IWiFiAdapterFactory
{
    IWiFiAdapter CreateWiFiAdapter();
}