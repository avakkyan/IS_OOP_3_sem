using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Мessage.Models;

public class Message : IMessage
{
    private const bool _isRead = false;
    public Message(string? title, string? body, ImportanceLevel importanceLevel)
    {
        Title = title;
        Body = body;
        IsRead = _isRead;
        MessageImportanceLevel = importanceLevel;
    }

    public string? Title { get; private set; }
    public string? Body { get; private set; }
    public bool IsRead { get; }
    public ImportanceLevel MessageImportanceLevel { get; private set; }
}