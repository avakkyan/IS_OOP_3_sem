using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;

public class Disconnect : ICommand
{
    public Disconnect(string address)
    {
        CommandValueAddress = address;
    }

    public string? CommandValueAddress { get; }
    public void Execute(FilePath? filePath)
    {
        if (CommandValueAddress != null) filePath?.Update(CommandValueAddress);
    }
}