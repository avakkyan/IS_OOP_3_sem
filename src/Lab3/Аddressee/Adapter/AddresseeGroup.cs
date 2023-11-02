using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;

public class AddresseeGroup : IAddressee
{
    private IList<IAddressee> addressees = new List<IAddressee>();

    public void AddAddressee(IAddressee addressee)
    {
        addressees.Add(addressee);
    }

    public void RemoveAddressee(IAddressee addressee)
    {
        addressees.Remove(addressee);
    }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        foreach (IAddressee addressee in addressees)
        {
            addressee.GetMessageAdapting(message, consoleColor);
        }
    }

    public void LogMessage(IMessage message)
    {
        Console.WriteLine($"Message : {message?.Title}: {message?.Body} ");
    }
}