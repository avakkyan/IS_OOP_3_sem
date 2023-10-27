using Itmo.ObjectOrientedProgramming.Lab2.DataBase;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;

public interface IStorage : IComputerDetail
{
    int StorageCapacity { get; }
    double StoragePowerConsumption { get; }
}