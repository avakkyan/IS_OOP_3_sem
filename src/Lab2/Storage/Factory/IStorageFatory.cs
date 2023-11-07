using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;

public interface IStorageFatory
{
    IStorage CreateStorage(
        int capacity,
        double powerConsumption,
        string name);
}