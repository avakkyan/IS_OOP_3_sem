using System;
using Itmo.ObjectOrientedProgramming.Lab3.Output.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver.Interfaces;

public interface IDisplayDriver
{
    void SetColor(ConsoleColor color);
    void WriteOnDisplay(IMessage message);
    void SetOutput(IOutput outputMessage);
    void ClearDisplay();
}