using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;

public class AddresseeUserMockTestFour : IAddressee
{
    private ImportanceLevel _importanceLevel;
    private IAddressee _addressee;

    public AddresseeUserMockTestFour(ImportanceLevel importanceLevel, IAddressee addressee)
    {
        _importanceLevel = importanceLevel;
        _addressee = addressee;
        IsRecieved = false;
    }

    public bool IsRecieved { get; private set; }
    public void GetMessage(IMessage message)
    {
        if (message is not null && message.MessageImportanceLevel == _importanceLevel)
        {
            _addressee.GetMessage(message);
            IsRecieved = true;
        }
    }
}