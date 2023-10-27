using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Factory;

public class TpLinkArcherFactory : IWiFiAdapterFactory
{
    public IWiFiAdapter CreateWiFiAdapter()
    {
        return new TpLinkArcherWiFiAdapter();
    }
}