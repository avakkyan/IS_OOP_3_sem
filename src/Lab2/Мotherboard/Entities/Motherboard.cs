using System;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Entities;

public class Motherboard : IAsrockMotherboard, ICloneable
{
    public Motherboard(
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
        MyChipset chipsetMotherboard,
        MyFormFactor formFactorMotherboard)
    {
        MotherboardSocket = socketMotherboard;
        PciExpressAmount = pciExpressAmount;
        SataAmount = sataAmount;
        MotherboardChipset = chipsetMotherboard;
        PowerConsumption = powerConsumption;
        MotherboardBios = bios;
        MotherboardDdrStandard = ddrStandard;
        RamTablesAmount = ramTablesAmount;
        MotherboardFormFactor = formFactorMotherboard;
        BiosType = biosType;
        BiosVersion = biosVersionType;
        Name = name;
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

    public Motherboard UpdateMotherboardSocket(MySocket motherboardSocket)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.MotherboardSocket = motherboardSocket;
        return motherboard;
    }

    public Motherboard UpdatePciExpressAmount(int pciExpressAmount)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.PciExpressAmount = pciExpressAmount;
        return motherboard;
    }

    public Motherboard UpdateSataAmount(int sataAmount)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.SataAmount = sataAmount;
        return motherboard;
    }

    public Motherboard UpdateMotherboardChipset(MyChipset motherboardChipset)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.MotherboardChipset = motherboardChipset;
        return motherboard;
    }

    public Motherboard UpdateMotherboardDdrStandard(int motherboardDdrStandard)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.MotherboardDdrStandard = motherboardDdrStandard;
        return motherboard;
    }

    public Motherboard UpdateMotherboardRamTablesAmount(int ramTablesAmount)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.RamTablesAmount = ramTablesAmount;
        return motherboard;
    }

    public Motherboard UpdateMotherboardFormFactor(MyFormFactor motherboardFormFactor)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.MotherboardFormFactor = motherboardFormFactor;
        return motherboard;
    }

    public Motherboard UpdateMotherboardBiosType(int biosType)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.BiosType = biosType;
        return motherboard;
    }

    public Motherboard UpdateMotherboardBiosVersion(int biosVersion)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.BiosType = biosVersion;
        return motherboard;
    }

    public Motherboard UpdateMotherboardPowerConsumption(int powerConsumption)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.PowerConsumption = powerConsumption;
        return motherboard;
    }

    public Motherboard UpdateMotherboardName(string name)
    {
        var motherboard = (Motherboard)Clone();
        motherboard.Name = name;
        return motherboard;
    }

    public object Clone()
    {
        return new Motherboard(
            PciExpressAmount,
            SataAmount,
            MotherboardDdrStandard,
            RamTablesAmount,
            PowerConsumption,
            BiosType,
            BiosVersion,
            Name,
            MotherboardBios,
            MotherboardSocket,
            MotherboardChipset,
            MotherboardFormFactor);
    }
}