using Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;

public class SsdStorageFacroty : IStorageFatory
{
    public IStorage CreateStorage()
    {
        return new SsdStorageApacerPanther();
    }
}