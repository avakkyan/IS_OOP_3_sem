using Itmo.ObjectOrientedProgramming.Lab2.Bios.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Interfaces;

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
        IBios? computerBios,
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
        ComputerBios = computerBios;
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
    public IBios? ComputerBios { get; private set; }
    public IHddStorage? ComputerHdd { get; private set; }
    public ISsdStorage? ComputerSsd { get; private set; }
    public IMotherboard? ComputerMotherboard { get; private set; }
    public IWiFiAdapter? ComputerWiFiAdapter { get; private set; }
}
