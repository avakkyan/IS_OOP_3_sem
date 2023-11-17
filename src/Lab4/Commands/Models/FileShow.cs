using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;

public class FileShow : ICommand
{
    public FileShow(string pathValue, string modeValue)
    {
        PathValue = pathValue;
        ModeValue = modeValue;
    }

    public string? PathValue { get; }
    public string? ModeValue { get; }

    public void Execute(ref Address? address)
    {
        if (address?.Value != null && PathValue != null)
        {
             string thePath = Path.Combine(address.Value, PathValue);
             Console.WriteLine($"Information in the file: {thePath} in mode {ModeValue}");
        }
    }
}