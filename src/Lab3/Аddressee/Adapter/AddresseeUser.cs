using System;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.User.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;

public class AddresseeUser : IAddressee
{
    private readonly MyUser _addresseeUser;
    private ILogger logger;
    private ImportanceLevel _importanceLevel = ImportanceLevel.None;

    public AddresseeUser()
    {
        _addresseeUser = new MyUser();
        logger = new MyLogger();
    }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        if (FilteringMessages(message))
        {
            _addresseeUser.GetMessage(message);
            logger.LogMessage(message);
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
