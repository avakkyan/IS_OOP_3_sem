using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;

public class TreeGoTo : ICommand
{
    public TreeGoTo(string commandValuePath)
    {
        CommandValuePath = commandValuePath;
    }

    public string? CommandValuePath { get; }

    public void Execute(ref Address? address)
    {
        if (CommandValuePath != null) address?.Update(CommandValuePath);
    }
}