namespace Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

public interface IMessage
{
    string? Title { get; }
    string? Body { get; }
    bool IsRead { get; }
    ImportanceLevel MessageImportanceLevel { get; }
}