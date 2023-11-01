using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Interfaces;

public interface IUser
{
    string Name { get; }
    void GetMessage(IMessage message);
    void IsRead(IMessage message);
}