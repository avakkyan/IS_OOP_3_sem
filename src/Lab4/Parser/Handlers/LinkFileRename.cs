using Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkFileRename : LinkBase
{
    private string? _path = string.Empty;
    private string? _name = string.Empty;
    public ICommand? Command { get; private set; }

    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "rename")
        {
            return Next?.Handle(myRequest);
        }

        _path = myRequest?.FindElement(2);
        _name = myRequest?.FindElement(3);
        if (_path != null && _name != null)
        {
            Command = new FileRename(_path, _name);
        }

        return Command;
    }
}