using Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Factory;

public interface IMotherboardFactory
{
    IMotherboard CreateMotherboard(
        int pciExpressAmount,
        int sataAmount,
        int ddrStandard,
        int ramTablesAmount,
        int powerConsumption,
        int biosType,
        double biosVersionType,
        string name,
        IBios bios,
        MySocket socketMotherboard,
        MyChipset chipsetMotherboard);
}