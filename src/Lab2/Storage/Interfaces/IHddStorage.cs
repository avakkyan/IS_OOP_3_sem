using Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

public interface IHddStorage : IStorage
{
    int SpindleRotationSpeed { get; }
    StorageConnectionType HddConnection { get; }
}