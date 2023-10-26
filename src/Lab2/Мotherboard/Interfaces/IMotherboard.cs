using Itmo.ObjectOrientedProgramming.Lab2.DataBase;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Chipsets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Interfaces;

public interface IMotherboard : IComputerDetail
{
    MySocket MotherboardSocket { get; }
    int PciExpressAmount { get; }
    int SataAmount { get; }
    MyChipset MotherboardChipset { get; }
    int MotherboardDdrStandard { get; }
    int RamTablesAmount { get; }
    MyFormFactor MotherboardFormFactor { get; }
    int BiosType { get; }
    double BiosVersion { get; }
}