using Itmo.ObjectOrientedProgramming.Lab3.User.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Models;

public class MessageProxy : IMessageProxy
{
    public MessageStatus? ReadMessage(MessageStatus? message)
    {
        if (message?.IsRead is false)
        {
            return message with { IsRead = true };
        }

        return message;
    }
}