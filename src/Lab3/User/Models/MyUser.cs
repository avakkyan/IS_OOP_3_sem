using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Models;

public class MyUser
{
    private IList<IMessage>? _messages = new List<IMessage>();

    public void IsRead(IMessage message)
    {
        if (!message.IsRead)
        {
            Console.WriteLine("You have a new message");
        }
    }

    public void GetMessage(IMessage message)
    {
        _messages?.Add(message);
    }
}