using Itmo.ObjectOrientedProgramming.Lab3.Мessage;
using Itmo.ObjectOrientedProgramming.Lab3.Мessage.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.ServiceInterfaces;

public interface IMyBuilderMessage
{
    public Message CreateMessage();
    public IMyBuilderMessage WithTitle(string title);
    public IMyBuilderMessage WithBody(string body);
    public IMyBuilderMessage WithImportanceLevel(ImportanceLevel importanceLevel);
}