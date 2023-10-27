namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

public interface ISsdStorage : IStorage
{
    int MaximumOperatingSpeed { get; }
    int? SsdConnectionSata { get; }
    int? SsdConnectionPci { get; }
}