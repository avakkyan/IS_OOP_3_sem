using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Models;

public abstract class LinkBase : ILink
{
    protected ILink? Next { get; private set; }

    public void AddNext(ILink link)
    {
        if (Next is null)
        {
            Next = link;
        }
        else
        {
            Next.AddNext(link);
        }
    }

    public abstract void Handle(MyRequest myRequest);
}