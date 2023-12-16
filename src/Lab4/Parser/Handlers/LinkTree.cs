using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;
using ICommand = Itmo.ObjectOrientedProgramming.Lab4.Commands.Interfaces.ICommand;

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

    public override ICommand? Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(0) != "tree")
        {
            return Next?.Handle(myRequest);
        }

        if (myRequest != null) return SubNext?.Handle(myRequest);
        return null;
    }
}