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

    public (IMyBuilder MyBuilder, Result Result) WithCooler(ICooler? computerCooler)
    {
        _cooler = (ICooler?)computerCooler;
        if (_cooler?.CoolerTdp is not null && _cpu?.HeatRelease is not null)
        {
            if (_cpu.HeatRelease > _cooler.CoolerTdp)
            {
                return (this, Result.ProcessorTdpIsBiggerThenCoolerTdp);
            }
        }

        return (this, Result.ElementSuccess);
    }

    public (IMyBuilder MyBuilder, Result Result) WithCpu(IMyСpu? computerCpu)
    {
        _cpu = (IMyСpu?)computerCpu;
        if (_cpu?.CpuSocket is not null &&
            _motherboard?.MotherboardSocket is not null)
        {
            if (!_motherboard.SocketCheck(_cpu.CpuSocket))
            {
                return (this, Result.SocketIsNotSuitable);
            }
        }
        else
        {
            return (this, Result.ErrorIsComputerAssembly);
        }

        if (_motherboard?.MotherboardBios?.CpuList is not null && _cpu is not null)
        {
            if (!_motherboard.MotherboardBios.CheckBios())
            {
                return (this, Result.BiosIsNotSuitable);
            }
        }
        else
        {
            return (this, Result.ErrorIsComputerAssembly);
        }

        return (this, Result.ElementSuccess);
    }

    public (IMyBuilder MyBuilder, Result Result) WithGpu(IGpu? computerGpu)
    {
        _gpu = (IGpu?)computerGpu;
        if (_computerCase?.CaseHeightForVideoCard is not null
            && _gpu?.GpuHeight is not null)
        {
            if (_computerCase.CaseHeightForVideoCard < _gpu.GpuHeight)
            {
                return (this, Result.CaseLengthIsNotSuitableToViseoCard);
            }
        }
        else
        {
            return (this, Result.ErrorIsComputerAssembly);
        }

        return (this, Result.ElementSuccess);
    }

    public (IMyBuilder MyBuilder, Result Result) WithPowerUnit(IPowerUnit? computerPowerUnit)
    {
        _powerUnit = (IPowerUnit?)computerPowerUnit;
        {
            if (_motherboard?.PowerConsumption is not null &&
                _ssdStorage?.PowerConsumption is not null &&
                _hddStorage?.PowerConsumption is not null &&
                _cooler?.PowerConsumption is not null &&
                _cpu?.PowerConsumption is not null &&
                _ram?.PowerConsumption is not null &&
                _gpu?.PowerConsumption is not null &&
                _wiFiAdapter?.PowerConsumption is not null &&
                _powerUnit?.PowerConsumption is not null)
            {
                if (_motherboard?.PowerConsumption +
                    _ssdStorage?.PowerConsumption +
                    _hddStorage?.PowerConsumption +
                    _cooler?.PowerConsumption +
                    _cpu?.PowerConsumption +
                    _ram?.PowerConsumption +
                    _gpu?.PowerConsumption +
                    _wiFiAdapter?.PowerConsumption +
                    _powerUnit?.PowerConsumption > _powerUnit?.PeakLoad)
                {
                    return (this, Result.PowerCapasicyIsNotEnough);
                }
            }
            else
            {
                return (this, Result.ErrorIsComputerAssembly);
            }

            return (this, Result.ElementSuccess);
        }
    }

    public (IMyBuilder MyBuilder, Result Result) WithRam(IRam? computerRam)
    {
        _ram = (IRam?)computerRam;
        if (_motherboard?.MotherboardDdrStandard is not null &&
            _ram?.RamDdrStandard is not null)
        {
            if (_motherboard.MotherboardDdrStandard != _ram.RamDdrStandard)
            {
                return (this, Result.DdrStandardIsNotSuitable);
            }
        }
        else
        {
            return (this, Result.ErrorIsComputerAssembly);
        }

        return (this, Result.ElementSuccess);
    }

    public (IMyBuilder MyBuilder, Result Result) WithHdd(IHddStorage? hddStorage)
    {
        _hddStorage = (IHddStorage?)hddStorage;

        if (_hddStorage?.HddConnection is not null &&
            _motherboard?.SataAmount is not null)
        {
            if (_hddStorage.HddConnection != _motherboard.SataAmount)
            {
                return (this, Result.HddIsNotSuitable);
            }
        }
        else
        {
            return (this, Result.ErrorIsComputerAssembly);
        }

        return (this, Result.ElementSuccess);
    }

    public (IMyBuilder MyBuilder, Result Result) WithSdd(ISsdStorage? ssdStorage)
    {
        _ssdStorage = (ISsdStorage?)ssdStorage;
        if (_ssdStorage?.SsdConnectionSata is not null &&
            _motherboard?.SataAmount is not null)
        {
            if (_ssdStorage.SsdConnectionSata != _motherboard.SataAmount)
            {
                return (this, Result.SsdIsNotSuitable);
            }
        }

        if (_ssdStorage?.SsdConnectionPci is null && _motherboard?.PciExpressAmount is not null)
        {
            if (_ssdStorage?.SsdConnectionPci > 0 && _motherboard.PciExpressAmount == 0)
            {
                return (this, Result.SsdIsNotSuitable);
            }
        }

        return (this, Result.ElementSuccess);
    }

    public IMyBuilder WithWiFiAdapter(IWiFiAdapter? computerWiFiAdapter)
    {
        _wiFiAdapter = (IWiFiAdapter?)computerWiFiAdapter;
        return this;
    }

    public (IMyBuilder MyBuilder, Result Result) WithMotherboard(IMotherboard? computerMotherboard)
    {
        _motherboard = (IMotherboard?)computerMotherboard;
        if (_computerCase?.FormFactorList is not null &&
            _motherboard?.MotherboardFormFactor is not null)
        {
            if (!_computerCase.CheckFormFactor())
            {
                return (this, Result.FormFactorMotherboeardIsNotSuitableToCase);
            }
        }

        return (this, Result.ElementSuccess);
    }
}