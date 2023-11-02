using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;

public interface IDisplay
{
    void ShowMessage(string? message, ConsoleColor color);
}