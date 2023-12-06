using System;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;

public interface IDisplay
{
    void ShowMessage(IMessage message, ConsoleColor color);
}