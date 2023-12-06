using Itmo.ObjectOrientedProgramming.Lab3.Messanger.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.AdresseesType;

public class AddresseeMessanger : IAddressee
{
    private readonly MyMessanger _myMessangerAreesee;

    public AddresseeMessanger(MyMessanger myMessangerAreesee)
    {
        _myMessangerAreesee = myMessangerAreesee;
    }

    public void GetMessage(IMessage message)
    {
        _myMessangerAreesee.GetMessage(message);
    }
}