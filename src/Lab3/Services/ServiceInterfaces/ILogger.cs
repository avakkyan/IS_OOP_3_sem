using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;

public interface ILogger
{
    void LogMessage(IMessage? message);
}