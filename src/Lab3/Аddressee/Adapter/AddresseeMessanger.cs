using Itmo.ObjectOrientedProgramming.Lab3.Messanger.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;

public class AddresseeMessanger : IAddressee
{
    private readonly MyMessanger _myMessangerAreesee;
    public AddresseeMessanger()
    {
        _myMessangerAreesee = new MyMessanger();
    }

    public void GetMessageAdapting(IMessage message)
    {
        _myMessangerAreesee.GetMessage(message);
    }
}