using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Мessage.Models;

public class Message : IMessage
{
    public Message(string? title, string? body, ImportanceLevel importanceLevel)
    {
        Title = title;
        Body = body;
        MessageImportanceLevel = importanceLevel;
    }

    public string? Title { get; private set; }
    public string? Body { get; private set; }
    public ImportanceLevel MessageImportanceLevel { get; private set; }
}