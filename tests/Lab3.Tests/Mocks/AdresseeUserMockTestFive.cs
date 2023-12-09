using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class AdresseeUserMockTestFive : IAddressee
{
    private IAddressee _addreseess;
    private ILogger _logger;

    public AdresseeUserMockTestFive(IAddressee addreseess, ILogger logger)
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