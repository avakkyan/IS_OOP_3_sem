using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topic.Interfaces;

public interface ITopic
{
    string Name { get; }
    void SendMessageFromTopic(IMessage message);
}