using System;
using Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;

public class AddresseeDisplay : IAddressee
{
    private readonly IDisplay display;

    public AddresseeDisplay(IDisplay display)
    {
        this.display = display;
    }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        display.ShowMessage(message?.Title, ConsoleColor.Black);
    }

    public void LogMessage(IMessage message)
    {
        Console.WriteLine($"Message : {message?.Title}: {message?.Body} ");
    }
}