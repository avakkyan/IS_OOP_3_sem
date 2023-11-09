using System;
using Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.AdresseesType;

public class AddresseeDisplay : IAddressee
{
    private readonly IDisplay display;
    public AddresseeDisplay(IDisplay display)
    {
        this.display = display;
    }

    public void GetMessage(IMessage message)
    {
        display.ShowMessage(message?.Title, ConsoleColor.Black);
    }
}