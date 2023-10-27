using System;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Entities;

public class AsrockMotherboard : IAsrockMotherboard, ICloneable
{
    private const int _asrockPciExpressAmount = 0;
    private const int _asrockSataAmount = 4;
    private const int _asrockDdrStandart = 4;
    private const int _asrockRamTablesAmount = 2;
    private const int _asrockPowerConsumption = 40;
    private const int _asrockBiosType = 1;
    private const double _asrockbiosVersionType = 1.14;
    private const string _asrockRamName = "AsrockMotherboard";
    private IBios _asrockBios = new AmiBios();
    private MySocket _asrockSocket = new MySocketAm4();
    private MyChipset _asrockChipset = new ChipsetA320();
    private MyFormFactor _asrockFormFactor = new MicroAtxFormFactor();

    public AsrockMotherboard()
    {
        MotherboardSocket = _asrockSocket;
        PciExpressAmount = _asrockPciExpressAmount;
        SataAmount = _asrockSataAmount;
        MotherboardChipset = _asrockChipset;
        PowerConsumption = _asrockPowerConsumption;
        MotherboardBios = _asrockBios;
        MotherboardDdrStandard = _asrockDdrStandart;
        RamTablesAmount = _asrockRamTablesAmount;
        MotherboardFormFactor = _asrockFormFactor;
        BiosType = _asrockBiosType;
        BiosVersion = _asrockbiosVersionType;
        Name = _asrockRamName;
    }

    public MySocket MotherboardSocket { get; private set; }
    public int PciExpressAmount { get; private set; }
    public int SataAmount { get; private set; }
    public MyChipset MotherboardChipset { get; private set; }
    public int MotherboardDdrStandard { get; private set; }
    public IBios MotherboardBios { get; private set; }
    public int RamTablesAmount { get; private set; }
    public MyFormFactor MotherboardFormFactor { get; private set; }
    public int BiosType { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public double BiosVersion { get; private set; }
    public bool SocketCheck(MySocket mySocket)
    {
        return mySocket is MySocketAm4;
    }

    public bool CheckFormFactor(MyFormFactor myFormFactor)
    {
        return myFormFactor is MicroAtxFormFactor;
    }

    public bool CheckBios(IBios bios)
    {
        return bios is AmiBios;
    }

    public AsrockMotherboard UpdateMotherboardSocket(MySocket motherboardSocket)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.MotherboardSocket = motherboardSocket;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdatePciExpressAmount(int pciExpressAmount)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.PciExpressAmount = pciExpressAmount;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateSataAmount(int sataAmount)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.SataAmount = sataAmount;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateMotherboardChipset(MyChipset motherboardChipset)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.MotherboardChipset = motherboardChipset;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateMotherboardDdrStandard(int motherboardDdrStandard)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.MotherboardDdrStandard = motherboardDdrStandard;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateMotherboardRamTablesAmount(int ramTablesAmount)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.RamTablesAmount = ramTablesAmount;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateMotherboardFormFactor(MyFormFactor motherboardFormFactor)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.MotherboardFormFactor = motherboardFormFactor;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateMotherboardBiosType(int biosType)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.BiosType = biosType;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateMotherboardBiosVersion(int biosVersion)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.BiosType = biosVersion;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateMotherboardPowerConsumption(int powerConsumption)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.PowerConsumption = powerConsumption;
        return asrockB550Motherboard;
    }

    public AsrockMotherboard UpdateMotherboardName(string name)
    {
        var asrockB550Motherboard = (AsrockMotherboard)Clone();
        asrockB550Motherboard.Name = name;
        return asrockB550Motherboard;
    }

    public object Clone()
    {
        return new AsrockMotherboard();
    }
}