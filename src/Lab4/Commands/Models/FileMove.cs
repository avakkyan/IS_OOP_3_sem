using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;

public class FileMove : ICommand
{
    public FileMove(string sourcePathValue, string destinationPathValue)
    {
        SourcePathValue = sourcePathValue;
        DestinationPathValue = destinationPathValue;
    }

    public string? SourcePathValue { get; }
    public string? DestinationPathValue { get; }

    public void Execute(ref Address? address)
    {
        if (address?.Value != null && SourcePathValue != null && DestinationPathValue != null)
        {
            string oldpath = Path.Combine(address.Value, SourcePathValue);
            string newpath = Path.Combine(address.Value, DestinationPathValue);
            File.Move(oldpath, newpath);
        }
    }
}