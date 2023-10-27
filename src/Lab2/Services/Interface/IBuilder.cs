using Itmo.ObjectOrientedProgramming.Lab2.Bios.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Interface;

public interface IBuilder
{
    public MyComputer CreateComputer();
    public IBuilder WithCase(IComputerCase computerCase);
    public IBuilder WithBios(IBios computerBios);
    public IBuilder WithCooler(ICooler computerCooler);
    public IBuilder WithCpu(IMyСpu computerCpu);
    public IBuilder WithGpu(IGpu computerGpu);
    public IBuilder WithPowerUnit(IPowerUnit coomputerPowerUnit);
    public IBuilder WithRam(IRam computerRam);
    public IBuilder WithHdd(IHddStorage hddStorage);
    public IBuilder WithSdd(ISsdStorage ssdStorage);
    public IBuilder WithWiFiAdapter(IWiFiAdapter computerWiFiAdapter);
    public IBuilder WithMotherboeard(IMotherboard computerMotherboard);
}