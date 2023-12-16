using Itmo.ObjectOrientedProgramming.Lab3.User.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Interfaces;

public interface IMessageProxy
{
    MessageStatus? ReadMessage(MessageStatus? message);
}