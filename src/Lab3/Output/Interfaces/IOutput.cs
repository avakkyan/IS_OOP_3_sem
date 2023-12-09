using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Output.Interfaces;

public interface IOutput
{
    void OutputMessage(IMessage message);
}