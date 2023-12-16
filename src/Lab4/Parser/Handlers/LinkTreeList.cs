using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;
using ICommand = Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces.ICommand;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkTreelist : LinkBase
{
    private string? _depth = string.Empty;
    public LinkTreelist()
    {
        Command = new TreeList(_depth);
    }

    private ICommand? Command { get; }
    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "list")
        {
            return Next?.Handle(myRequest);
        }

        _depth = myRequest?.FindElement(3);
        return Command;
    }
}