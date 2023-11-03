using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messanger.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Mocks;

public class AddresseeMessangerMock : IAddressee
{
    private readonly MyMessanger _myMessangerAreesee;
    private MyLogger _logger;
    private ImportanceLevel _importanceLevel;

    public AddresseeMessangerMock()
    {
        _myMessangerAreesee = new MyMessanger();
        _logger = new MyLogger();
    }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        if (FilteringMessages(message))
        {
            _myMessangerAreesee.GetMessage(message);
            _logger.LogMessage(message);
        }
    }

    public void SetImportanceLevel(ImportanceLevel importanceLevel)
    {
        _importanceLevel = importanceLevel;
    }

    public bool FilteringMessages(IMessage message)
    {
        if (message?.MessageImportanceLevel == _importanceLevel)
        {
            return true;
        }

        return false;
    }
}