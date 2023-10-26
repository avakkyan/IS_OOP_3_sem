using Itmo.ObjectOrientedProgramming.Lab2.DataBase;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiStandard;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Interfaces;

public interface IWiFiAdapter : IComputerDetail
{
    bool IsBluetoothModule { get; }
    double WiFiPciEVersion { get; }
    TypeWiFiStandard WiFiAdapterStandart { get; }
}