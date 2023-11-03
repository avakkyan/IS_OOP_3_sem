using System;
using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.User.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Mocks;

public class AdresseeUserMockTestFive : IAddressee
{
    private ImportanceLevel _importanceLevel = ImportanceLevel.None;
    public AdresseeUserMockTestFive()
    {
        MyAddresseeUser = new MyUser();
        Logger = new LoggerMock();
    }

    public MyUser MyAddresseeUser { get; }
    public ILogger Logger { get; }
    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        if (FilteringMessages(message))
        {
            MyAddresseeUser.GetMessage(message);
            Logger.LogMessage(message);
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