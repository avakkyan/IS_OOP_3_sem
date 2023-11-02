using System;
using Itmo.ObjectOrientedProgramming.Lab3.DisolayDriver.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisolayDriver.Models;

public class DisplayDriver : IDisplayDriver
{
    private string? textWriting = string.Empty;
    private ConsoleColor textColor = ConsoleColor.Black;
    public void SetColor(ConsoleColor color)
    {
        textColor = color;
    }

    public void WriteOnDisplay(IMessage message)
    {
        Console.ForegroundColor = textColor;
        Console.WriteLine(message?.Body);
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