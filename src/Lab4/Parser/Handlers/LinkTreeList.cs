using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkTreelist : LinkBase
{
    private string? _depth = string.Empty;
    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "list")
        {
            Next?.Handle(myRequest);
            return;
        }

        _depth = myRequest?.FindElement(3);
        return;
    }
}