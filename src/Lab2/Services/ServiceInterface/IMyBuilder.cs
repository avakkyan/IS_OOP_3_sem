using Itmo.ObjectOrientedProgramming.Lab2.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.ServiceInterface;

public interface IMyBuilder
{
    public MyComputer CreateComputer();
    public IMyBuilder WithCase(IComputerCase? computerCase);
    public (IMyBuilder MyBuilder, Result Result) WithCooler(ICooler? computerCooler);
    public (IMyBuilder MyBuilder, Result Result) WithCpu(IMyСpu? computerCpu);
    public (IMyBuilder MyBuilder, Result Result) WithGpu(IGpu? computerGpu);
    public (IMyBuilder MyBuilder, Result Result) WithPowerUnit(IPowerUnit? computerPowerUnit);
    public (IMyBuilder MyBuilder, Result Result) WithRam(IRam? computerRam);
    public (IMyBuilder MyBuilder, Result Result) WithHdd(IHddStorage? hddStorage);
    public (IMyBuilder MyBuilder, Result Result) WithSdd(ISsdStorage? ssdStorage);
    public IMyBuilder WithWiFiAdapter(IWiFiAdapter? computerWiFiAdapter);
    public (IMyBuilder MyBuilder, Result Result) WithMotherboard(IMotherboard? computerMotherboard);
}