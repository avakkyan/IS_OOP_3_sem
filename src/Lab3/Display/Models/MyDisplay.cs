using System;
using Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Display.Models;

public class MyDisplay : IDisplay
{
    private readonly IDisplayDriver _displayDriver;
    private MyDisplay(MyDisplayDriver displayDriver)
    {
        _displayDriver = displayDriver;
    }

    public void ShowMessage(IMessage message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        _displayDriver.WriteOnDisplay(message);
    }
}