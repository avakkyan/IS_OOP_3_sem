using System;
using Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.AdresseesType;

public class AddresseeDisplay : IAddressee
{
    private readonly IDisplay _display;
    public AddresseeDisplay(IDisplay display)
    {
        _display = display;
    }

    public void GetMessage(IMessage message)
    {
        _display.ShowMessage(message, ConsoleColor.Black);
    }
}