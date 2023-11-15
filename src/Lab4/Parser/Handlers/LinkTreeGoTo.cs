﻿using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkTreeGoTo : LinkBase
{
    private string? _path = string.Empty;
    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(1) != "goto")
        {
            Next?.Handle(myRequest);
            return;
        }

        _path = myRequest?.FindElement(2);
        return;
    }
}