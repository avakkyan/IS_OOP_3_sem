using Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;

public class SsdStorageFacroty : IStorageFatory
{
    public IStorage CreateStorage()
    {
        return new SsdStorageApacerPanther();
    }
}