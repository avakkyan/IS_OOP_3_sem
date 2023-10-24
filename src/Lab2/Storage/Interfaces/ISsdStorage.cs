using Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

public interface ISsdStorage : IStorage
{
    int MaximumOperatingSpeed { get; }
    StorageConnectionType SsdConnection { get; }
}