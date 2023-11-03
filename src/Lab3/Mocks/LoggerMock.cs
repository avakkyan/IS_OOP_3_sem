using System;
using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Mocks;

public class LoggerMock : ILogger
{
    public string? MockLogMessage { get; private set; }
    public void LogMessage(IMessage? message)
    {
        Console.WriteLine($"Message got addressee with title {message?.Title}");
        MockLogMessage = $"Message got addressee with title {message?.Title}";
    }
}