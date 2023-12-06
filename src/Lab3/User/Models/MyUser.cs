using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.User.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Models;

public class MyUser : IUser
{
    private readonly IMessageProxy _messageProxy;
    private IList<MessageStatus> _messages = new List<MessageStatus>();

    public MyUser(IMessageProxy messageProxy, IList<MessageStatus> messages)
    {
        _messageProxy = messageProxy;
        _messages = messages;
    }

    public void GetMessage(IMessage message)
    {
        _messages?.Add(new MessageStatus(message, false));
    }

    public void ReadMessage(IMessage message)
    {
        MessageStatus? messageStatus = _messages.FirstOrDefault(targetMessage =>
            targetMessage.Message.Body is not null &&
            targetMessage.Message.Body.Equals(message.Body, StringComparison.Ordinal));

        if (messageStatus is not null)
        {
            MessageStatus? newMessage = _messageProxy.ReadMessage(messageStatus);
            if (newMessage is not null)
            {
                _messages[_messages.IndexOf(messageStatus)] = newMessage;
            }
        }
    }
}