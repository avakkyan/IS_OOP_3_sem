using System;
using Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Output.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver.Models;

public class MyDisplayDriver : IDisplayDriver
{
    private IOutput? textWriting;
    private ConsoleColor textColor = ConsoleColor.Black;

    public void SetColor(ConsoleColor color)
    {
        textColor = color;
    }

    public void SetOutput(IOutput outputMessage)
    {
        textWriting = outputMessage;
    }

    public void WriteOnDisplay(IMessage message)
    {
        Console.ForegroundColor = textColor;
        textWriting?.OutputMessage(message);
        Console.ResetColor();
    }

    public void ClearDisplay()
    {
        textWriting = null;
    }
}