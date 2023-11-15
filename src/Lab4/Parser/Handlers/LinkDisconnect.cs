using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkDisconnect : LinkBase
{
    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(0) != "disconnect")
        {
            Next?.Handle(myRequest);
            return;
        }
    }
}