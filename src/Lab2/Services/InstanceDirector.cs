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

public class InstanceDirector : IBuilderDirerctor
{
    private IMyСpu? _cpu;
    private IComputerCase _computerCase;
    private ICooler? _cooler;
    private IGpu? _gpu;
    private IPowerUnit? _powerUnit;
    private IRam? _ram;
    private IHddStorage? _hddStorage;
    private ISsdStorage? _ssdStorage;
    private IWiFiAdapter? _wiFiAdapter;
    private IMotherboard? _motherboard;
    private IMyBuilder _builder;

    public InstanceDirector(
        MyBuilder builder,
        IMyСpu? cpu,
        IComputerCase computerCase,
        ICooler? cooler,
        IGpu? gpu,
        IPowerUnit? powerUnit,
        IRam? ram,
        IHddStorage? hddStorage,
        ISsdStorage? ssdStorage,
        IWiFiAdapter? wiFiAdapter,
        IMotherboard? motherboard)
    {
        _builder = builder;
        _cpu = cpu;
        _computerCase = computerCase;
        _cooler = cooler;
        _gpu = gpu;
        _powerUnit = powerUnit;
        _ram = ram;
        _hddStorage = hddStorage;
        _ssdStorage = ssdStorage;
        _wiFiAdapter = wiFiAdapter;
        _motherboard = motherboard;
    }

    public (IMyBuilder MyBuilder, Result Result) Direct()
    {
        Result result;
        _builder.WithCase(_computerCase);
        (_builder, result) = _builder.WithMotherboard(_motherboard);
        if (result != Result.ElementSuccess)
        {
            return (_builder, result);
        }

        (_builder, result) = _builder.WithCpu(_cpu);
        if (result != Result.ElementSuccess)
        {
            return (_builder, result);
        }

        (_builder, result) = _builder.WithCooler(_cooler);
        if (result != Result.ElementSuccess)
        {
            return (_builder, result);
        }

        (_builder, result) = _builder.WithGpu(_gpu);
        if (result != Result.ElementSuccess)
        {
            return (_builder, result);
        }

        (_builder, result) = _builder.WithRam(_ram);
        if (result != Result.ElementSuccess)
        {
            return (_builder, result);
        }

        (_builder, result) = _builder.WithPowerUnit(_powerUnit);
        if (result != Result.ElementSuccess)
        {
            return (_builder, result);
        }

        (_builder, result) = _builder.WithHdd(_hddStorage);
        if (result != Result.ElementSuccess)
        {
            return (_builder, result);
        }

        (_builder, result) = _builder.WithSdd(_ssdStorage);
        if (result != Result.ElementSuccess)
        {
            return (_builder, result);
        }

        _builder.WithWiFiAdapter(_wiFiAdapter);
        return (_builder, result);
    }
}