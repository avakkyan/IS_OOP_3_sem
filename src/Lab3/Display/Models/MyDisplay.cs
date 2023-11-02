using System;
using Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Display.Models;

public class MyDisplay : IDisplay
{
    public void ShowMessage(string? message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine("{Message: {message}}");
        Console.ResetColor();
    }
}