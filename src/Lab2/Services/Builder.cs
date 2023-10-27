using Itmo.ObjectOrientedProgramming.Lab2.Bios.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Interface;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class Builder : IBuilder
{
    private IMyСpu? _cpu;
    private IComputerCase? _computerCase;
    private ICooler? _cooler;
    private IGpu? _gpu;
    private IPowerUnit? _powerUnit;
    private IRam? _ram;
    private IBios? _bios;
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
            _bios,
            _hddStorage,
            _ssdStorage,
            _wiFiAdapter,
            _motherboard);
    }

    public IBuilder WithCase(IComputerCase computerCase)
    {
        _computerCase = (IComputerCase)computerCase;
        return this;
    }

    public IBuilder WithBios(IBios computerBios)
    {
        _bios = (IBios)computerBios;
        return this;
    }

    public IBuilder WithCooler(ICooler computerCooler)
    {
        _cooler = (ICooler)computerCooler;
        return this;
    }

    public IBuilder WithCpu(IMyСpu computerCpu)
    {
        _cpu = (IMyСpu)computerCpu;
        return this;
    }

    public IBuilder WithGpu(IGpu computerGpu)
    {
        _gpu = (IGpu)computerGpu;
        return this;
    }

    public IBuilder WithPowerUnit(IPowerUnit coomputerPowerUnit)
    {
        _powerUnit = (IPowerUnit)coomputerPowerUnit;
        return this;
    }

    public IBuilder WithRam(IRam computerRam)
    {
        _ram = (IRam)computerRam;
        return this;
    }

    public IBuilder WithHdd(IHddStorage hddStorage)
    {
        _hddStorage = (IHddStorage)hddStorage;
        return this;
    }

    public IBuilder WithSdd(ISsdStorage ssdStorage)
    {
        _ssdStorage = (ISsdStorage)ssdStorage;
        return this;
    }

    public IBuilder WithWiFiAdapter(IWiFiAdapter computerWiFiAdapter)
    {
        _wiFiAdapter = (IWiFiAdapter)computerWiFiAdapter;
        return this;
    }

    public IBuilder WithMotherboeard(IMotherboard computerMotherboard)
    {
        _motherboard = (IMotherboard)computerMotherboard;
        return this;
    }
}