using Itmo.ObjectOrientedProgramming.Lab3.Result;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Interfaces;

public interface IUser
{
    void GetMessage(IMessage message);
    MessageResult ReadMessage(IMessage message);
    bool CheckNewContains(IMessage message);
    bool CheckStoryContains(IMessage message);
}