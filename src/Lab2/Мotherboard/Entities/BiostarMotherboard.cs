using System;
using Itmo.ObjectOrientedProgramming.Lab2.FormFactor.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Entities;

public class BiostarMotherboard : IBiostarMotherboard, ICloneable
{
    private const int _biostarPciExpressAmount = 1;
    private const int _biostarSataAmount = 4;
    private const int _biostarDdrStandart = 4;
    private const int _biostarRamTablesAmount = 2;
    private const int _biostarPowerConsumption = 39;
    private const int _biostarBiosType = 1;
    private const double _biostarbiosVersionType = 1.14;
    private const string _biostarName = "BiostarMotherboard";
    private MySocket _biostarSocket = new MySocketAm4();
    private MyChipset _biostarChipset = new ChipsetA320();
    private MyFormFactor _biostarFormFactor = new MicroAtxFormFactor();

    public BiostarMotherboard()
    {
        MotherboardSocket = _biostarSocket;
        PciExpressAmount = _biostarPciExpressAmount;
        SataAmount = _biostarSataAmount;
        PowerConsumption = _biostarPowerConsumption;
        MotherboardChipset = _biostarChipset;
        MotherboardDdrStandard = _biostarDdrStandart;
        RamTablesAmount = _biostarRamTablesAmount;
        MotherboardFormFactor = _biostarFormFactor;
        BiosType = _biostarBiosType;
        BiosVersion = _biostarbiosVersionType;
        Name = _biostarName;
    }

    public MySocket MotherboardSocket { get; private set; }
    public int PciExpressAmount { get; private set; }
    public int SataAmount { get; private set; }
    public MyChipset MotherboardChipset { get; private set; }
    public int MotherboardDdrStandard { get; private set; }
    public int RamTablesAmount { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public MyFormFactor MotherboardFormFactor { get; private set; }
    public int BiosType { get; private set; }
    public double BiosVersion { get; private set; }

    public BiostarMotherboard UpdateMotherboardSocket(MySocket motherboardSocket)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.MotherboardSocket = motherboardSocket;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdatePciExpressAmount(int pciExpressAmount)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.PciExpressAmount = pciExpressAmount;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateSataAmount(int sataAmount)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.SataAmount = sataAmount;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateMotherboardChipset(MyChipset motherboardChipset)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.MotherboardChipset = motherboardChipset;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateMotherboardDdrStandard(int motherboardDdrStandard)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.MotherboardDdrStandard = motherboardDdrStandard;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateMotherboardRamTablesAmount(int ramTablesAmount)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.RamTablesAmount = ramTablesAmount;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateMotherboardFormFactor(MyFormFactor motherboardFormFactor)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.MotherboardFormFactor = motherboardFormFactor;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateMotherboardBiosType(int biosType)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.BiosType = biosType;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateMotherboardBiosVersion(int biosVersion)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.BiosType = biosVersion;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateMotherboardPowerConsumption(int powerConsumption)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.PowerConsumption = powerConsumption;
        return biostarA320Motherboard;
    }

    public BiostarMotherboard UpdateMotherboardName(string name)
    {
        var biostarA320Motherboard = (BiostarMotherboard)Clone();
        biostarA320Motherboard.Name = name;
        return biostarA320Motherboard;
    }

    public object Clone()
    {
        return new AsrockMotherboard();
    }
}