using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;

public interface IStorageFatory
{
    IStorage CreateStorage();
}