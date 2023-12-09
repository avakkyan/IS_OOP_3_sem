using Itmo.ObjectOrientedProgramming.Lab3.User.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.AdresseesType;

public class AddresseeUser : IAddressee
{
    public AddresseeUser(IUser user)
    {
        MyAddresseeUser = user;
    }

    public IUser MyAddresseeUser { get; }

    public void GetMessage(IMessage message)
    {
        MyAddresseeUser.GetMessage(message);
    }
}
