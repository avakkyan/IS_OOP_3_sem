using System;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer;

public class MyComputer : ICloneable
{
    public MyComputer(
        IMyСpu? copmputerCpu,
        IComputerCase? computerCase,
        ICooler? computerCooler,
        IGpu? computerGpu,
        IPowerUnit? computerPowerUnit,
        IRam? computerRam,
        IHddStorage? computerHdd,
        ISsdStorage? computerSsd,
        IWiFiAdapter? computerWiFiAdapter,
        IMotherboard? computerMotherboard)
    {
        ComputerCpu = copmputerCpu;
        ComputerCase = computerCase;
        ComputerCooler = computerCooler;
        ComputerGpu = computerGpu;
        ComputerPowerUnit = computerPowerUnit;
        ComputerRam = computerRam;
        ComputerHdd = computerHdd;
        ComputerSsd = computerSsd;
        ComputerWiFiAdapter = computerWiFiAdapter;
        ComputerMotherboard = computerMotherboard;
    }

    public IMyСpu? ComputerCpu { get; private set; }
    public IComputerCase? ComputerCase { get; private set; }
    public ICooler? ComputerCooler { get; private set; }
    public IGpu? ComputerGpu { get; private set; }
    public IPowerUnit? ComputerPowerUnit { get; private set; }
    public IRam? ComputerRam { get; private set; }
    public IHddStorage? ComputerHdd { get; private set; }
    public ISsdStorage? ComputerSsd { get; private set; }
    public IMotherboard? ComputerMotherboard { get; private set; }
    public IWiFiAdapter? ComputerWiFiAdapter { get; private set; }

    public MyComputer UpdateComputerCpu(IMyСpu computerCpu)
    {
        var myComputer = (MyComputer)Clone();
        myComputer.ComputerCpu = computerCpu;
        return myComputer;
    }

    public MyComputer UpdateComputerCase(IComputerCase computerCase)
    {
        var myComputer = (MyComputer)Clone();
        myComputer.ComputerCase = computerCase;
        return myComputer;
    }

    public MyComputer UpdateComputerCpu(ICooler computerCooler)
    {
        var myComputer = (MyComputer)Clone();
        myComputer.ComputerCooler = computerCooler;
        return myComputer;
    }

    public MyComputer UpdateComputerPowerUnit(IPowerUnit computerPowerUnit)
    {
        var myComputer = (MyComputer)Clone();
        myComputer.ComputerPowerUnit = computerPowerUnit;
        return myComputer;
    }

    public MyComputer UpdateComputerRam(IRam computerRam)
    {
        var myComputer = (MyComputer)Clone();
        myComputer.ComputerRam = computerRam;
        return myComputer;
    }

    public MyComputer UpdateComputerHdd(IHddStorage computerHdd)
    {
        var myComputer = (MyComputer)Clone();
        myComputer.ComputerHdd = computerHdd;
        return myComputer;
    }

    public MyComputer UpdateComputerMotherboard(IMotherboard computerMotherboard)
    {
        var myComputer = (MyComputer)Clone();
        myComputer.ComputerMotherboard = computerMotherboard;
        return myComputer;
    }

    public MyComputer UpdateWiFiAdapter(IWiFiAdapter computerWiFiAdapter)
    {
        var myComputer = (MyComputer)Clone();
        myComputer.ComputerWiFiAdapter = computerWiFiAdapter;
        return myComputer;
    }

    public object Clone()
    {
        return new MyComputer(
            ComputerCpu,
            ComputerCase,
            ComputerCooler,
            ComputerGpu,
            ComputerPowerUnit,
            ComputerRam,
            ComputerHdd,
            ComputerSsd,
            ComputerWiFiAdapter,
            ComputerMotherboard);
    }
}
