namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

public interface IHddStorage : IStorage
{
    int SpindleRotationSpeed { get; }
    int HddConnection { get; }
}