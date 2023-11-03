using System;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.User.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Mocks;

public class AddresseeUserMockTestFour : IAddressee
{
    private ILogger logger;
    private ImportanceLevel _importanceLevelmock = ImportanceLevel.NotVeryImportant;
    public AddresseeUserMockTestFour()
    {
        MyAddresseeUser = new MyUser();
        logger = new MyLogger();
    }

    public MyUser MyAddresseeUser { get; }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        if (FilteringMessages(message))
        {
            MyAddresseeUser.GetMessage(message);
            logger.LogMessage(message);
        }
    }

    public void SetImportanceLevel(ImportanceLevel importanceLevel)
    {
        _importanceLevelmock = importanceLevel;
    }

    public bool FilteringMessages(IMessage message)
    {
        if (message?.MessageImportanceLevel == _importanceLevelmock)
        {
            return true;
        }

        return false;
    }
}
