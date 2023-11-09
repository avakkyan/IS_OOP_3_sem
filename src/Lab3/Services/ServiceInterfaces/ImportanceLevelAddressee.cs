using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;

public class ImportanceLevelAddressee : IAddressee
{
    private ImportanceLevel _importanceLevel;
    private IAddressee _addressee;

    public ImportanceLevelAddressee(ImportanceLevel importanceLevel, IAddressee addressee)
    {
        _importanceLevel = importanceLevel;
        _addressee = addressee;
    }

    public void GetMessage(IMessage message)
    {
        if (message is not null && message.MessageImportanceLevel == _importanceLevel)
        {
            _addressee.GetMessage(message);
        }
    }
}