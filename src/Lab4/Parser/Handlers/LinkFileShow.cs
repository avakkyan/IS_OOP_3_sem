using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkFileShow : LinkBase
{
    private string? _path = string.Empty;
    private string? _mode = string.Empty;

    public LinkFileShow()
    {
        Command = new FileShow(_path, _mode);
    }

    private ICommand? Command { get; }

    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "show")
        {
            return Next?.Handle(myRequest);
        }

        _path = myRequest?.FindElement(2);
        _mode = myRequest?.FindElement(4);
        return Command;
    }
}