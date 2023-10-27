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

public class MyComputer
{
    public MyComputer(
        IMyСpu? copmputerCpu,
        IComputerCase? computerComputerCase,
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
        ComputerComputerCase = computerComputerCase;
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
    public IComputerCase? ComputerComputerCase { get; private set; }
    public ICooler? ComputerCooler { get; private set; }
    public IGpu? ComputerGpu { get; private set; }
    public IPowerUnit? ComputerPowerUnit { get; private set; }
    public IRam? ComputerRam { get; private set; }
    public IHddStorage? ComputerHdd { get; private set; }
    public ISsdStorage? ComputerSsd { get; private set; }
    public IMotherboard? ComputerMotherboard { get; private set; }
    public IWiFiAdapter? ComputerWiFiAdapter { get; private set; }
}
