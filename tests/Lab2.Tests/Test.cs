using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.ComputerCaseInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.GpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.PowerUnitInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Services.ServiceInterface;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.StorageInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.MotherboardInterfaces;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class Test
{
    private static Result elementSuccess = Result.ElementSuccess;
    private static Result powerCapasicyIsNotEnough = Result.PowerCapasicyIsNotEnough;
    private static Result processorTdpIsBiggerThenCoolerTdp = Result.ProcessorTdpIsBiggerThenCoolerTdp;
    private static Result socketIsNotSuitable = Result.SocketIsNotSuitable;

    public static TheoryData<Result> TestSuccessfullyAssembledData => new()
    {
        { elementSuccess },
    };

    public static TheoryData<Result> TestPeakPowerOfUnitPowerIsNotEnoughData => new()
    {
        { powerCapasicyIsNotEnough },
    };

    public static TheoryData<Result> TestCoolerTdpIsNotenoughData => new()
    {
        { processorTdpIsBiggerThenCoolerTdp },
    };

    public static TheoryData<Result> TestCpuSocketIsNotSuitableToMotherboardData => new()
    {
        { socketIsNotSuitable },
    };

    [Theory]
    [MemberData(nameof(TestSuccessfullyAssembledData))]
    public void TestSuccessfullyAssembled(Result elementSuccess)
    {
        var computerRepository = new Repository();
        string amdAthlon = "CpuAmdAthlon";
        string coolerIdCooling = "CoolerIdCooling";
        string ardorCase = "ArdorGamingCase";
        string msiGeForceGpu = "MsiGeForceGpu";
        string hddblue = "HddStorageWdBlue";
        string asrockmotherboard = "AsrockMotherboard";
        string adataRam = "AdataRam";
        string apacerPantherSsd = "SsdStorageApacerPanther";
        string cougarPowerUnit = "CougarPowerUnit";
        string depxWiFi = "DexpWiFiAdapter";
        IMyBuilder computerOneBuilder = new MyBuilder();
        Result result;
        var computerCpu = (IAmdCpu?)computerRepository.FindMyDetail(amdAthlon);
        var computerCooler = (ICoolingIdCooler?)computerRepository.FindMyDetail(coolerIdCooling);
        var computerCase = (IComputerCase?)computerRepository.FindMyDetail(ardorCase);
        var computerGpu = (IGpu?)computerRepository.FindMyDetail(msiGeForceGpu);
        var computerHdd = (IHddStorage?)computerRepository.FindMyDetail(hddblue);
        var computerMotherboard = (IMotherboard?)computerRepository.FindMyDetail(asrockmotherboard);
        var computerRam = (IRam?)computerRepository.FindMyDetail(adataRam);
        var computerSsd = (ISsdStorage?)computerRepository.FindMyDetail(apacerPantherSsd);
        var computerPowerUnit = (IPowerUnit?)computerRepository.FindMyDetail(cougarPowerUnit);
        var computerWiFi = (IWiFiAdapter?)computerRepository.FindMyDetail(depxWiFi);
        IBuilderDirerctor instanceDirector = new InstanceDirector(
            computerOneBuilder,
            computerCpu,
            computerCase,
            computerCooler,
            computerGpu,
            computerPowerUnit,
            computerRam,
            computerHdd,
            computerSsd,
            computerWiFi,
            computerMotherboard);
        (_, result) = instanceDirector.Direct();
        Assert.Equal(elementSuccess, result);
    }

    [Theory]
    [MemberData(nameof(TestPeakPowerOfUnitPowerIsNotEnoughData))]
    public void TestPeakPowerOfUnitPowerIsNotEnough(Result powerCapasicyIsNotEnough)
    {
        var computerRepository = new Repository();
        string amdAthlon = "CpuAmdAthlon";
        string coolerIdCooling = "CoolerIdCooling";
        string ardorCase = "ArdorGamingCase";
        string msiGeForceGpu = "MsiGeForceGpu";
        string hddblue = "HddStorageWdBlue";
        string asrockmotherboard = "AsrockMotherboard";
        string adataRam = "AdataRam";
        string apacerPantherSsd = "SsdStorageApacerPanther";
        string cougarPowerUnit = "DeepcoolPowerUnit";
        string depxWiFi = "DexpWiFiAdapter";
        IMyBuilder computerOneBuilder = new MyBuilder();
        Result result;
        var computerCpu = (IAmdCpu?)computerRepository.FindMyDetail(amdAthlon);
        var computerCooler = (ICoolingIdCooler?)computerRepository.FindMyDetail(coolerIdCooling);
        var computerCase = (IComputerCase?)computerRepository.FindMyDetail(ardorCase);
        var computerGpu = (IGpu?)computerRepository.FindMyDetail(msiGeForceGpu);
        var computerHdd = (IHddStorage?)computerRepository.FindMyDetail(hddblue);
        var computerMotherboard = (IMotherboard?)computerRepository.FindMyDetail(asrockmotherboard);
        var computerRam = (IRam?)computerRepository.FindMyDetail(adataRam);
        var computerSsd = (ISsdStorage?)computerRepository.FindMyDetail(apacerPantherSsd);
        var computerPowerUnit = (IPowerUnit?)computerRepository.FindMyDetail(cougarPowerUnit);
        var computerWiFi = (IWiFiAdapter?)computerRepository.FindMyDetail(depxWiFi);
        IBuilderDirerctor instanceDirector = new InstanceDirector(
            computerOneBuilder,
            computerCpu,
            computerCase,
            computerCooler,
            computerGpu,
            computerPowerUnit,
            computerRam,
            computerHdd,
            computerSsd,
            computerWiFi,
            computerMotherboard);
        (_, result) = instanceDirector.Direct();
        Assert.Equal(powerCapasicyIsNotEnough, result);
    }

    [Theory]
    [MemberData(nameof(TestCoolerTdpIsNotenoughData))]
    public void TestCoolerTdpIsNotenough(Result processorTdpIsBiggerThenCoolerTdp)
    {
        var computerRepository = new Repository();
        string amdAthlon = "CpuAmdAthlon";
        string coolerIsDeepcool = "CoolerDeepcool";
        string ardorCase = "ArdorGamingCase";
        string msiGeForceGpu = "MsiGeForceGpu";
        string hddblue = "HddStorageWdBlue";
        string asrockmotherboard = "AsrockMotherboard";
        string adataRam = "AdataRam";
        string apacerPantherSsd = "SsdStorageApacerPanther";
        string cougarPowerUnit = "CougarPowerUnit";
        string depxWiFi = "DexpWiFiAdapter";
        IMyBuilder computerOneBuilder = new MyBuilder();
        Result result;
        var computerCpu = (IAmdCpu?)computerRepository.FindMyDetail(amdAthlon);
        var computerCooler = (IDeepcoolCooler?)computerRepository.FindMyDetail(coolerIsDeepcool);
        var computerCase = (IComputerCase?)computerRepository.FindMyDetail(ardorCase);
        var computerGpu = (IGpu?)computerRepository.FindMyDetail(msiGeForceGpu);
        var computerHdd = (IHddStorage?)computerRepository.FindMyDetail(hddblue);
        var computerMotherboard = (IMotherboard?)computerRepository.FindMyDetail(asrockmotherboard);
        var computerRam = (IRam?)computerRepository.FindMyDetail(adataRam);
        var computerSsd = (ISsdStorage?)computerRepository.FindMyDetail(apacerPantherSsd);
        var computerPowerUnit = (IPowerUnit?)computerRepository.FindMyDetail(cougarPowerUnit);
        var computerWiFi = (IWiFiAdapter?)computerRepository.FindMyDetail(depxWiFi);
        IBuilderDirerctor instanceDirector = new InstanceDirector(
            computerOneBuilder,
            computerCpu,
            computerCase,
            computerCooler,
            computerGpu,
            computerPowerUnit,
            computerRam,
            computerHdd,
            computerSsd,
            computerWiFi,
            computerMotherboard);
        (_, result) = instanceDirector.Direct();
        Assert.Equal(processorTdpIsBiggerThenCoolerTdp, result);
    }

    [Theory]
    [MemberData(nameof(TestCpuSocketIsNotSuitableToMotherboardData))]
    public void TestCpuSocketIsNotSuitableToMotherboard(Result socketIsNotSuitable)
    {
        var computerRepository = new Repository();
        string amdAthlon = "CpuIntelCorei3";
        string coolerIdCooling = "CoolerIdCooling";
        string ardorCase = "ArdorGamingCase";
        string msiGeForceGpu = "MsiGeForceGpu";
        string hddblue = "HddStorageWdBlue";
        string asrockmotherboard = "AsrockMotherboard";
        string adataRam = "AdataRam";
        string apacerPantherSsd = "SsdStorageApacerPanther";
        string cougarPowerUnit = "CougarPowerUnit";
        string depxWiFi = "DexpWiFiAdapter";
        IMyBuilder computerOneBuilder = new MyBuilder();
        Result result;
        var computerCpu = (IIntelCpu?)computerRepository.FindMyDetail(amdAthlon);
        var computerCooler = (ICoolingIdCooler?)computerRepository.FindMyDetail(coolerIdCooling);
        var computerCase = (IComputerCase?)computerRepository.FindMyDetail(ardorCase);
        var computerGpu = (IGpu?)computerRepository.FindMyDetail(msiGeForceGpu);
        var computerHdd = (IHddStorage?)computerRepository.FindMyDetail(hddblue);
        var computerMotherboard = (IMotherboard?)computerRepository.FindMyDetail(asrockmotherboard);
        var computerRam = (IRam?)computerRepository.FindMyDetail(adataRam);
        var computerSsd = (ISsdStorage?)computerRepository.FindMyDetail(apacerPantherSsd);
        var computerPowerUnit = (IPowerUnit?)computerRepository.FindMyDetail(cougarPowerUnit);
        var computerWiFi = (IWiFiAdapter?)computerRepository.FindMyDetail(depxWiFi);
        IBuilderDirerctor instanceDirector = new InstanceDirector(
            computerOneBuilder,
            computerCpu,
            computerCase,
            computerCooler,
            computerGpu,
            computerPowerUnit,
            computerRam,
            computerHdd,
            computerSsd,
            computerWiFi,
            computerMotherboard);
        (_, result) = instanceDirector.Direct();
        Assert.Equal(socketIsNotSuitable, result);
    }
}