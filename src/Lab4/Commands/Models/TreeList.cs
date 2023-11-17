using System;
using System.Collections.Generic;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;

public class TreeList : ICommand
{
    public TreeList(string commandValueDepth)
    {
        CommandValueDepth = commandValueDepth;
    }

    public string? CommandValueDepth { get; }

    public void Execute(ref Address? address)
    {
        try
        {
            if (address?.Value != null)
            {
                string docPath = address.Value;

                var dirs = new List<string>(Directory.EnumerateDirectories(docPath));

                foreach (string dir in dirs)
                {
                    Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
                }

                Console.WriteLine($"{dirs.Count} directories found.");
            }
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}