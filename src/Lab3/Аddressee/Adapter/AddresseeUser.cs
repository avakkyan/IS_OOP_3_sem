using System;
using Itmo.ObjectOrientedProgramming.Lab3.User.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;

public class AddresseeUser : IAddressee
{
    private readonly MyUser _addresseeUser;

    public AddresseeUser()
    {
        _addresseeUser = new MyUser();
    }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        _addresseeUser.GetMessage(message);
    }

    public void LogMessage(IMessage message)
    {
        Console.WriteLine($"Message : {message?.Title}: {message?.Body} ");
    }
}