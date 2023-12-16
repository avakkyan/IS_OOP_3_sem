using Itmo.ObjectOrientedProgramming.Lab4.AddressObject;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;

public interface ICommand
{
    void Execute(FilePath? filePath);
}