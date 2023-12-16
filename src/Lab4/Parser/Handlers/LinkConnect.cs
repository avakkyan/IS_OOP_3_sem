using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkConnect : LinkBase
{
    private string? _address = string.Empty;
    private string? _mode = string.Empty;

    public ICommand? Command { get; private set; }

    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(0) != "connect")
        {
            return Next?.Handle(myRequest);
        }

        _address = myRequest?.FindElement(1);
        _mode = myRequest?.FindElement(3);
        if (_address != null && _mode != null)
            Command = new Connect(_address, _mode);
        return Command;
    }
}