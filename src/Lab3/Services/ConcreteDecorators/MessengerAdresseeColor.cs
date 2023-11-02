using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messanger.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Аddressee.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.ConcreteDecorators;

public class MessengerAdresseeColor : IAddressee, IColorDecorator
{
    private IMessanger messanger;
    private ConsoleColor textColor;

    public MessengerAdresseeColor(IMessanger messanger)
    {
        this.messanger = messanger;
        textColor = ConsoleColor.Black;
    }

    public void GetMessageAdapting(IMessage message, ConsoleColor consoleColor)
    {
        Console.ForegroundColor = textColor;
        messanger.ShowMessage(message?.Body);
        Console.ResetColor();
    }

    public void SetColor(ConsoleColor textColor)
    {
        this.textColor = textColor;
    }

    public void LogMessage(IMessage message)
    {
        Console.WriteLine($"Message : {message?.Title}: {message?.Body} ");
    }
}