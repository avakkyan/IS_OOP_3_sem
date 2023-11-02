using System;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisolayDriver.Interfaces;

public interface IDisplayDriver
{
    void SetColor(ConsoleColor color);
    void WriteOnDisplay(IMessage message);
    void ClearDisplay();
}