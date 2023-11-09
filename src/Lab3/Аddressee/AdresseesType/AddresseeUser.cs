using Itmo.ObjectOrientedProgramming.Lab3.User.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.AdresseesType;

public class AddresseeUser : IAddressee
{
    public AddresseeUser()
    {
        MyAddresseeUser = new MyUser();
    }

    public MyUser MyAddresseeUser { get; }

    public void GetMessage(IMessage message)
    {
        MyAddresseeUser.GetMessage(message);
    }
}
