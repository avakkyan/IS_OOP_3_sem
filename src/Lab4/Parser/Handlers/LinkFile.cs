using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class LinkFile : LinkBase
{
    public LinkFile()
    {
        var linkFileShow = new LinkFileShow();
        var linkFileMove = new LinkFileMove();
        var linkFileCopy = new LinkFileCopy();
        var linkFileDelete = new LinkFileDelete();
        var linkFileRename = new LinkFileRename();
        linkFileShow.AddNext(linkFileMove);
        linkFileMove.AddNext(linkFileCopy);
        linkFileCopy.AddNext(linkFileDelete);
        linkFileDelete.AddNext(linkFileRename);
    }

    private ILink? SubNext { get; }

    public override void Handle(MyRequest myRequest)
    {
        if (myRequest != null && myRequest.FindElement(0) != "file")
        {
            Next?.Handle(myRequest);
            return;
        }

        if (myRequest != null) SubNext?.Handle(myRequest);
        return;
    }
}