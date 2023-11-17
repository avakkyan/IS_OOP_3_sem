using Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

public interface ILink
{
    void AddNext(ILink link);

    Commands.Interfaces.ICommand? Handle(MyRequest myRequest);
}