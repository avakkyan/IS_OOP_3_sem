using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Factory;

public interface IWiFiAdapterFactory
{
    IWiFiAdapter CreateWiFiAdapter();
}