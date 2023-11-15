using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkFileRename : LinkBase
{
    private string? _path = string.Empty;
    private string? _name = string.Empty;

    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "rename")
        {
            Next?.Handle(myRequest);
            return;
        }

        _path = myRequest?.FindElement(2);
        _name = myRequest?.FindElement(3);
        return;
    }
}