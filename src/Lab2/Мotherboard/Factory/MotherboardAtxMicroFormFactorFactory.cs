using Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Factory;

public class MotherboardAtxMicroFormFactorFactory : IMotherboardFactory
{
    private readonly MyFormFactor _myFormFactor = new MicroAtxFormFactor();
    public IMotherboard CreateMotherboard(
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
        MyChipset chipsetMotherboard)
    {
        return new Motherboard(
            pciExpressAmount,
            sataAmount,
            ddrStandard,
            ramTablesAmount,
            powerConsumption,
            biosType,
            biosVersionType,
            name,
            bios,
            socketMotherboard,
            chipsetMotherboard,
            _myFormFactor);
    }
}