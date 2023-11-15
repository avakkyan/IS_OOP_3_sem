using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkTree : LinkBase
{
    public LinkTree()
    {
        var linkTreeGoTo = new LinkTreeGoTo();
        var linkTreeList = new LinkTreelist();
        linkTreeGoTo.AddNext(linkTreeList);
        SubNext = linkTreeGoTo;
    }

    private ILink? SubNext { get; }

    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(0) != "tree")
        {
            Next?.Handle(myRequest);
            return;
        }

        if (myRequest != null) SubNext?.Handle(myRequest);
        return;
    }
}