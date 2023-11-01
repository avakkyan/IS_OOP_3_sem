namespace Itmo.ObjectOrientedProgramming.Lab2.Services.ServiceInterface;

public interface IBuilderDirerctor
{
    (IMyBuilder MyBuilder, Result Result) Direct();
}