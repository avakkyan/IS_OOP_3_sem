using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Мessage.Models;

public class Message : IMessage
{
    private string title = string.Empty;
    private string body = string.Empty;
    private ImportanceLevel messageImportanceLevel = ImportanceLevel.None;

    public Message()
    {
        Title = title;
        Body = body;
        IsRead = false;
        MessageImportanceLevel = messageImportanceLevel;
    }

    public string Title { get; private set; }
    public string Body { get; private set; }
    public bool IsRead { get; }
    public ImportanceLevel MessageImportanceLevel { get; private set; }
}