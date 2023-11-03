using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messanger.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Mocks;

public class MyMessangerMock : IMessanger
{
    private IList<IMessage?> _messages = new List<IMessage?>();
    public string? MockMessagerMessage { get; private set; }
    public void ShowMessage(string? message)
    {
        MockMessagerMessage = $"New message {message}";
    }

    public void GetMessage(IMessage? message)
    {
        _messages.Add(message);
    }
}