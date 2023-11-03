using System;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;

public interface IAddressee
{
    void GetMessageAdapting(IMessage message, ConsoleColor consoleColor);
    bool FilteringMessages(IMessage message);
}