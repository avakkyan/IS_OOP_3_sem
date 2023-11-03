using System;
using Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver.Models;

public class DisplayDriver : IDisplayDriver
{
    private readonly IDisplay _display;
    private string? textWriting = string.Empty;
    private ConsoleColor textColor = ConsoleColor.Black;

    public DisplayDriver(IDisplay display)
    {
        _display = display;
    }

    public void SetColor(ConsoleColor color)
    {
        textColor = color;
    }

    public void WriteOnDisplay(IMessage message)
    {
        Console.ForegroundColor = textColor;
        _display.ShowMessage(message?.Body, textColor);
        Console.ResetColor();
    }

    public void ClearDisplay()
    {
        textWriting = string.Empty;
    }

    public void WriteMessage(IMessage message)
    {
        textWriting = message?.Body;
    }
}