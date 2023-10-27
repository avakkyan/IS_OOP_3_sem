using Itmo.ObjectOrientedProgramming.Lab2.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Services.ServiceInterface;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class MyBuilder : IMyBuilder
{
    private IMyСpu? _cpu;
    private IComputerCase? _computerCase;
    private ICooler? _cooler;
    private IGpu? _gpu;
    private IPowerUnit? _powerUnit;
    private IRam? _ram;
    private IHddStorage? _hddStorage;
    private ISsdStorage? _ssdStorage;
    private IWiFiAdapter? _wiFiAdapter;
    private IMotherboard? _motherboard;

    public MyComputer CreateComputer()
    {
        return new MyComputer(
            _cpu,
            _computerCase,
            _cooler,
            _gpu,
            _powerUnit,
            _ram,
            _hddStorage,
            _ssdStorage,
            _wiFiAdapter,
            _motherboard);
    }

    public IMyBuilder WithCase(IComputerCase? computerCase)
    {
        _computerCase = (IComputerCase?)computerCase;
        return this;
    }

    public IMyBuilder WithCooler(ICooler? computerCooler)
    {
        _cooler = (ICooler?)computerCooler;
        return this;
    }

    public IMyBuilder WithCpu(IMyСpu? computerCpu)
    {
        _cpu = (IMyСpu?)computerCpu;
        return this;
    }

    public IMyBuilder WithGpu(IGpu? computerGpu)
    {
        _gpu = (IGpu?)computerGpu;
        return this;
    }

    public IMyBuilder WithPowerUnit(IPowerUnit? coomputerPowerUnit)
    {
        _powerUnit = (IPowerUnit?)coomputerPowerUnit;
        return this;
    }

    public IMyBuilder WithRam(IRam? computerRam)
    {
        _ram = (IRam?)computerRam;
        return this;
    }

    public IMyBuilder WithHdd(IHddStorage? hddStorage)
    {
        _hddStorage = (IHddStorage?)hddStorage;
        return this;
    }

    public IMyBuilder WithSdd(ISsdStorage? ssdStorage)
    {
        _ssdStorage = (ISsdStorage?)ssdStorage;
        return this;
    }

    public IMyBuilder WithWiFiAdapter(IWiFiAdapter? computerWiFiAdapter)
    {
        _wiFiAdapter = (IWiFiAdapter?)computerWiFiAdapter;
        return this;
    }

    public IMyBuilder WithMotherboeard(IMotherboard? computerMotherboard)
    {
        _motherboard = (IMotherboard?)computerMotherboard;
        return this;
    }
}