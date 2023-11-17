using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkFileMove : LinkBase
{
    private string? _sourcePath = string.Empty;
    private string? _destinationPath = string.Empty;

    public ICommand? Command { get; private set; }

    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "move")
        {
            return Next?.Handle(myRequest);
        }

        _sourcePath = myRequest?.FindElement(2);
        _destinationPath = myRequest?.FindElement(3);
        if (_sourcePath != null && _destinationPath != null)
        {
            Command = new FileMove(_sourcePath, _destinationPath);
        }

        return Command;
    }
}