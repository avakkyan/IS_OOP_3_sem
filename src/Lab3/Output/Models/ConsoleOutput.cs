using System;
using Itmo.ObjectOrientedProgramming.Lab3.Output.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Output.Models;

public class ConsoleOutput : IOutput
{
    public void OutputMessage(IMessage message)
    {
        Console.WriteLine($"{{Message: {{message}}");
    }
}