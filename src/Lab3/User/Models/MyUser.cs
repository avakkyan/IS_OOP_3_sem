﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Models;

public class MyUser
{
    private ILogger? adreseeLogger = new MyLogger();
    private IList<IMessage> _messages = new List<IMessage>();

    public void IsRead(IMessage message)
    {
        if 
    }
    public void GetMessage(IMessage message)
    {
        _messages.Add(message);
        adreseeLogger?.LogMessage(message.Title);
    }
}