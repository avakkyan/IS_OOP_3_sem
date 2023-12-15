using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;

public class Connect : ICommand
{
    private const string Local = "local";
    public Connect(string commandValueAddress, string commandValueMode)
    {
        CommandValueAddress = commandValueAddress;
        CommandValueMode = commandValueMode;
    }

    public string? CommandValueMode { get; }
    public string? CommandValueAddress { get; }

    public void Execute(FilePath? filePath)
    {
        if (CommandValueAddress != null && CommandValueMode == Local) filePath?.Update(CommandValueAddress);
    }
}