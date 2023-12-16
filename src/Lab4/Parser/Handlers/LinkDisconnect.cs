using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkDisconnect : LinkBase
{
    public LinkDisconnect()
    {
        Command = new Disconnect(string.Empty);
    }

    private ICommand? Command { get; }

    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(0) != "disconnect")
        {
            return Next?.Handle(myRequest);
        }

        return Command;
    }
}