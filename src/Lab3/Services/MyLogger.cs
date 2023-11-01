using System;
using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class MyLogger : ILogger
{
    public void LogMessage(string messageTitle)
    {
        Console.WriteLine("Message got by {{addresseeName}} with title {{messageTitle}}");
    }
}