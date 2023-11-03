using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;

public class AddresseeGroup : IAddressee
{
    private IList<IAddressee> addressees = new List<IAddressee>();
    private MyLogger _logger = new MyLogger();
    private ImportanceLevel _importanceLevel;
    public void AddAddressee(IAddressee addressee)
    {
        addressees.Add(addressee);
    }

    public void RemoveAddressee(IAddressee addressee)
    {
        addressees.Remove(addressee);
    }

    public void SetImportanceLevel(ImportanceLevel importanceLevel)
    {
        _importanceLevel = importanceLevel;
    }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        foreach (IAddressee addressee in addressees)
        {
            if (FilteringMessages(message))
            {
                addressee.GetMessageAdapting(message, consoleColor);
                _logger.LogMessage(message);
            }
        }
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