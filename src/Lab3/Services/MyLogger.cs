using System;
using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class MyLogger : ILogger
{
public void LogMessage(IMessage? message)
    {
        Console.WriteLine($"Message got addressee with title {message?.Title}");
    }
}