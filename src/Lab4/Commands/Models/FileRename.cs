using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;

public class FileRename : ICommand
{
    public FileRename(string pathValue, string nameValue)
    {
        PathValue = pathValue;
        NameValue = nameValue;
    }

    public string? PathValue { get; }
    public string? NameValue { get; }

    public void Execute(ref FilePath? filePath)
    {
        if (filePath?.Value != null && PathValue != null && NameValue != null)
        {
            string oldpath = Path.Combine(filePath.Value, PathValue);
            string newpath = Path.Combine(filePath.Value, NameValue);
            File.Move(oldpath, newpath);
        }
    }
}