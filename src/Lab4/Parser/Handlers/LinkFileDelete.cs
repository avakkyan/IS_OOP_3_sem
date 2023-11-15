using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkFileDelete : LinkBase
{
    private string? _path = string.Empty;

    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "delete")
        {
            Next?.Handle(myRequest);
            return;
        }

        _path = myRequest?.FindElement(2);
        return;
    }
}