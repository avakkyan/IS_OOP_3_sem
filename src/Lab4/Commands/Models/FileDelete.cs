using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;

public class FileDelete : ICommand
{
    public FileDelete(string path)
    {
        CommandValuePath = path;
    }

    public string CommandValuePath { get; private set; }
    public void Execute(FilePath? filePath)
    {
        if (filePath?.Value != null)
        {
            string newpath = Path.Combine(filePath.Value, CommandValuePath);
            File.Delete(newpath);
        }
    }
}