using System.IO;
using Itmo.ObjectOrientedProgramming.Lab3.Output.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Output.Models;

public class FileOutput : IOutput
{
    public void OutputMessage(IMessage message)
    {
        using (var writer = new StreamWriter("output.txt", true))
        {
            writer.WriteLine(message);
        }
    }
}