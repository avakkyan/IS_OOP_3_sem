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
    public IMyBuilder WithCooler(ICooler? computerCooler);
    public IMyBuilder WithCpu(IMyСpu? computerCpu);
    public IMyBuilder WithGpu(IGpu? computerGpu);
    public IMyBuilder WithPowerUnit(IPowerUnit? coomputerPowerUnit);
    public IMyBuilder WithRam(IRam? computerRam);
    public IMyBuilder WithHdd(IHddStorage? hddStorage);
    public IMyBuilder WithSdd(ISsdStorage? ssdStorage);
    public IMyBuilder WithWiFiAdapter(IWiFiAdapter? computerWiFiAdapter);
    public IMyBuilder WithMotherboeard(IMotherboard? computerMotherboard);
}