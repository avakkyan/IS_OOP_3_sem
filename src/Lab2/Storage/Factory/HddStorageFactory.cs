using Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;

public class HddStorageFactory : IStorageFatory
{
    public IStorage CreateStorage()
    {
        return new HddStorageWdBlue();
    }
}