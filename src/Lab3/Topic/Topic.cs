using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topic;

public class Topic
{
    public Topic(string title, IAddressee addresee)
    {
        Title = title;
        Addresee = addresee;
    }

    private string Title { get; }
    private IAddressee Addresee { get; }
    private void SendTopicOfMessage(IMessage message)
    {
        Addresee.GetMessage(message);
    }
}