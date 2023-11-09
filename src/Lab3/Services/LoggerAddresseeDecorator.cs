using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class LoggerAddresseeDecorator : IAddressee
{
    private IAddressee _addreseess;
    private ILogger _logger;

    public LoggerAddresseeDecorator(IAddressee addreseess, ILogger logger)
    {
        _addreseess = addreseess;
        _logger = logger;
    }

    public void GetMessage(IMessage message)
    {
        _addreseess.GetMessage(message);
        _logger.LogMessage(message);
    }
}