using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.User.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Models;

public class MyUser : IUser
{
    private IList<IMessage?> _newMessages = new List<IMessage?>();
    private IList<IMessage> _messagesStory = new List<IMessage>();

    public void GetMessage(IMessage? message)
    {
        _newMessages?.Add(message);
    }

    public void ReadMessage(IMessage message)
    {
        if (_newMessages is not null)
        {
            _messagesStory.Add(message);
            _newMessages.Remove(message);
        }
    }
}