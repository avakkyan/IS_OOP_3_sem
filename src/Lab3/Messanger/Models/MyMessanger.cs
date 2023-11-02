using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messanger.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messanger.Models;

public class MyMessanger : IMessanger
{
    private IList<IMessage> _messages = new List<IMessage>();
    public void ShowMessage(string? message)
    {
        Console.WriteLine($"New message {message}");
    }

    public void GetMessage(IMessage message)
    {
        _messages.Add(message);
    }
}