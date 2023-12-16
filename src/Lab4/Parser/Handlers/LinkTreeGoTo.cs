using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;
using ICommand = Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces.ICommand;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkTreeGoTo : LinkBase
{
    private string? _path = string.Empty;

    public ICommand? Command { get; private set; }
    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "goto")
        {
            return Next?.Handle(myRequest);
        }

        _path = myRequest?.FindElement(2);
        if (_path != null) Command = new TreeGoTo(_path);
        return Command;
    }
}