using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tools;

public class SpaceException : Exception
{
    public SpaceException(string message)
    {
        Console.WriteLine(message);
    }

    public SpaceException()
    {
    }

    public SpaceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}