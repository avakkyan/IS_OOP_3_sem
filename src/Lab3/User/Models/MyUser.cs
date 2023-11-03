using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Result;
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

    public MessageResult ReadMessage(IMessage message)
    {
        if (_newMessages is not null && CheckNewContains(message))
        {
            _messagesStory.Add(message);
            _newMessages.Remove(message);
            return MessageResult.Success;
        }

        return MessageResult.NotSuccess;
    }

    public bool CheckNewContains(IMessage message)
    {
        if (_newMessages.Contains(message))
        {
            return true;
        }

        return false;
    }

    public bool CheckStoryContains(IMessage message)
    {
        if (_messagesStory.Contains(message))
        {
            return true;
        }

        return false;
    }
}