using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkFileDelete : LinkBase
{
    private string? _path = string.Empty;

    public LinkFileDelete()
    {
        Command = new FileDelete(_path);
    }

    private ICommand Command { get; }
    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "delete")
        {
            return Next?.Handle(myRequest);
        }

        _path = myRequest?.FindElement(2);
        return Command;
    }
}