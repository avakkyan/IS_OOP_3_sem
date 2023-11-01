using Itmo.ObjectOrientedProgramming.Lab3.User.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;

public class AddresseeUser : IAddressee
{
    private readonly MyUser _addresseeUser;

    public AddresseeUser()
    {
        _addresseeUser = new MyUser();
    }

    public void GetMessageAdapting(IMessage message)
    {
        _addresseeUser.GetMessage(message);
    }
}