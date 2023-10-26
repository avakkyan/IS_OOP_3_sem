using System;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Entities;

public class GigabyteMotherboard : IGigabyteMotherboard, ICloneable
{
    private const int _gigabytePciExpressAmount = 1;
    private const int _gigabyteSataAmount = 4;
    private const int _gigabyteDdrStandart = 4;
    private const int _gigabyteRamTablesAmount = 2;
    private const int _gigabyteBiosType = 1;
    private const int _gigabytePowerConsumption = 41;
    private const double _gigabytebiosVersionType = 1.14;
    private const string _gigabyteName = "GigabyteMotherboard";
    private MySocket _gigabyteSocket = new MySocketAm4();
    private MyChipset _gigabyteChipset = new ChipsetA320();
    private MyFormFactor _gigabyteFormFactor = new MicroAtxFormFactor();

    public GigabyteMotherboard()
    {
        MotherboardSocket = _gigabyteSocket;
        PciExpressAmount = _gigabytePciExpressAmount;
        SataAmount = _gigabyteSataAmount;
        MotherboardChipset = _gigabyteChipset;
        MotherboardDdrStandard = _gigabyteDdrStandart;
        RamTablesAmount = _gigabyteRamTablesAmount;
        PowerConsumption = _gigabytePowerConsumption;
        MotherboardFormFactor = _gigabyteFormFactor;
        BiosType = _gigabyteBiosType;
        BiosVersion = _gigabytebiosVersionType;
        Name = _gigabyteName;
    }

    public MySocket MotherboardSocket { get; private set; }
    public int PciExpressAmount { get; private set; }
    public int SataAmount { get; private set; }
    public MyChipset MotherboardChipset { get; private set; }
    public int MotherboardDdrStandard { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public int RamTablesAmount { get; private set; }
    public MyFormFactor MotherboardFormFactor { get; private set; }
    public int BiosType { get; private set; }
    public double BiosVersion { get; private set; }

    public GigabyteMotherboard UpdateMotherboardSocket(MySocket motherboardSocket)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.MotherboardSocket = motherboardSocket;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdatePciExpressAmount(int pciExpressAmount)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.PciExpressAmount = pciExpressAmount;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateSataAmount(int sataAmount)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.SataAmount = sataAmount;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateMotherboardChipset(MyChipset motherboardChipset)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.MotherboardChipset = motherboardChipset;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateMotherboardDdrStandard(int motherboardDdrStandard)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.MotherboardDdrStandard = motherboardDdrStandard;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateMotherboardRamTablesAmount(int ramTablesAmount)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.RamTablesAmount = ramTablesAmount;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateMotherboardFormFactor(MyFormFactor motherboardFormFactor)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.MotherboardFormFactor = motherboardFormFactor;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateMotherboardBiosType(int biosType)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.BiosType = biosType;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateMotherboardBiosVersion(int biosVersion)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.BiosType = biosVersion;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateMotherboardPowerConsumption(int powerConsumption)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.PowerConsumption = powerConsumption;
        return gigabyteB550Motherboard;
    }

    public GigabyteMotherboard UpdateMotherboardName(string name)
    {
        var gigabyteB550Motherboard = (GigabyteMotherboard)Clone();
        gigabyteB550Motherboard.Name = name;
        return gigabyteB550Motherboard;
    }

    public object Clone()
    {
        return new AsrockMotherboard();
    }
}