using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.User.Models;

public record MessageStatus(IMessage Message, bool IsRead);