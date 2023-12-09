using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class MyBuilderMessage : IMyBuilderMessage
{
    private string? _title;
    private string? _body;
    private ImportanceLevel _importanceLevel;

    public Message CreateMessage()
    {
        return new Message(
            _title,
            _body,
            _importanceLevel);
    }

    public IMyBuilderMessage WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public IMyBuilderMessage WithBody(string body)
    {
        _body = body;
        return this;
    }

    public IMyBuilderMessage WithImportanceLevel(ImportanceLevel importanceLevel)
    {
        _importanceLevel = importanceLevel;
        return this;
    }
}