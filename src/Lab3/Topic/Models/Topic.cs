using System;
using Itmo.ObjectOrientedProgramming.Lab3.Topic.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topic.Models;

public class Topic : ITopic
{
    public Topic(string name, IAddressee addresee)
    {
        Name = name;
        Addresee = addresee;
    }

    public string Name { get; }
    private IAddressee Addresee { get; }
    public void SendMessageFromTopic(IMessage message)
    {
        Addresee.GetMessageAdapting(message, ConsoleColor.Black);
    }
}