using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkFileMove : LinkBase
{
    private string? _sourcePath = string.Empty;
    private string? _destinationPath = string.Empty;

    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "move")
        {
            Next?.Handle(myRequest);
            return;
        }

        _sourcePath = myRequest?.FindElement(2);
        _destinationPath = myRequest?.FindElement(3);
        return;
    }
}