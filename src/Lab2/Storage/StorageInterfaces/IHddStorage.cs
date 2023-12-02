namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

public interface IHddStorage : IStorage
{
    int SpindleRotationSpeed { get; }
    int HddConnection { get; }
}