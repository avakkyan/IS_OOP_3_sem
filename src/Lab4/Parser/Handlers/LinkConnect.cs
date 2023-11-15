using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkConnect : LinkBase
{
    private string? _address = string.Empty;
    private string? _mode = string.Empty;
    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(0) != "connect")
        {
            Next?.Handle(myRequest);
            return;
        }

        _address = myRequest?.FindElement(1);
        _mode = myRequest?.FindElement(3);
    }
}