using System;
using Itmo.ObjectOrientedProgramming.Lab3.Display.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Adapter;

public class AddresseeDisplay : IAddressee
{
    private readonly IDisplay display;
    private MyLogger _logger;
    private ImportanceLevel _importanceLevel;
    public AddresseeDisplay(IDisplay display)
    {
        this.display = display;
        _logger = new MyLogger();
    }

    public void SetImportanceLevel(ImportanceLevel importanceLevel)
    {
        _importanceLevel = importanceLevel;
    }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        if (FilteringMessages(message))
        {
            display.ShowMessage(message?.Title, ConsoleColor.Black);
            _logger.LogMessage(message);
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