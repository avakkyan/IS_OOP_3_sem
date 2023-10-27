using Itmo.ObjectOrientedProgramming.Lab2.Computer;
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
        MyComputer myComputer = computerOneBuilder.WithCase((IComputerCase?)computerRepository.FindMyDetail(ardorCase))
            .WithCooler((ICooler?)computerRepository.FindMyDetail(coolerIdCooling))
            .WithGpu((IGpu?)computerRepository.FindMyDetail(msiGeForceGpu))
            .WithCpu((IMyСpu?)computerRepository.FindMyDetail(amdAthlon))
            .WithHdd((IHddStorage?)computerRepository.FindMyDetail(hddblue))
            .WithMotherboeard((IMotherboard?)computerRepository.FindMyDetail(asrockmotherboard))
            .WithRam((IRam?)computerRepository.FindMyDetail(adataRam))
            .WithSdd((ISsdStorage?)computerRepository.FindMyDetail(apacerPantherSsd))
            .WithPowerUnit((IPowerUnit?)computerRepository.FindMyDetail(cougarPowerUnit))
            .WithWiFiAdapter((IWiFiAdapter?)computerRepository.FindMyDetail(depxWiFi)).CreateComputer();
        var computerService = new MyComputerService(myComputer);
        Assert.Equal(elementSuccess, computerService.IsSocketRight());
        Assert.Equal(elementSuccess, computerService.IsCaseFormFactorRightToMotherboard());
        Assert.Equal(elementSuccess, computerService.IsCaseLengthRight());
        Assert.Equal(elementSuccess, computerService.IsBiosRight());
        Assert.Equal(elementSuccess, computerService.IsDdrStandardRight());
        Assert.Equal(elementSuccess, computerService.IsTdpCoolerEnough());
        Assert.Equal(elementSuccess, computerService.IsSsdRight());
        Assert.Equal(elementSuccess, computerService.IsHddRight());
        Assert.Equal(elementSuccess, computerService.IsPowerCapacityEnough());
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
        MyComputer myComputer = computerOneBuilder.WithCase((IComputerCase?)computerRepository.FindMyDetail(ardorCase))
            .WithCooler((ICooler?)computerRepository.FindMyDetail(coolerIdCooling))
            .WithGpu((IGpu?)computerRepository.FindMyDetail(msiGeForceGpu))
            .WithCpu((IMyСpu?)computerRepository.FindMyDetail(amdAthlon))
            .WithHdd((IHddStorage?)computerRepository.FindMyDetail(hddblue))
            .WithMotherboeard((IMotherboard?)computerRepository.FindMyDetail(asrockmotherboard))
            .WithRam((IRam?)computerRepository.FindMyDetail(adataRam))
            .WithSdd((ISsdStorage?)computerRepository.FindMyDetail(apacerPantherSsd))
            .WithPowerUnit((IPowerUnit?)computerRepository.FindMyDetail(cougarPowerUnit))
            .WithWiFiAdapter((IWiFiAdapter?)computerRepository.FindMyDetail(depxWiFi)).CreateComputer();
        var computerService = new MyComputerService(myComputer);
        Assert.Equal(elementSuccess, computerService.IsSocketRight());
        Assert.Equal(elementSuccess, computerService.IsCaseFormFactorRightToMotherboard());
        Assert.Equal(elementSuccess, computerService.IsCaseLengthRight());
        Assert.Equal(elementSuccess, computerService.IsBiosRight());
        Assert.Equal(elementSuccess, computerService.IsDdrStandardRight());
        Assert.Equal(elementSuccess, computerService.IsTdpCoolerEnough());
        Assert.Equal(elementSuccess, computerService.IsSsdRight());
        Assert.Equal(elementSuccess, computerService.IsHddRight());
        Assert.Equal(powerCapasicyIsNotEnough, computerService.IsPowerCapacityEnough());
    }

    [Theory]
    [MemberData(nameof(TestCoolerTdpIsNotenoughData))]
    public void TestCoolerTdpIsNotenough(Result processorTdpIsBiggerThenCoolerTdp)
    {
        var computerRepository = new Repository();
        string amdAthlon = "CpuAmdAthlon";
        string coolerIdCooling = "CoolerDeepcool";
        string ardorCase = "ArdorGamingCase";
        string msiGeForceGpu = "MsiGeForceGpu";
        string hddblue = "HddStorageWdBlue";
        string asrockmotherboard = "AsrockMotherboard";
        string adataRam = "AdataRam";
        string apacerPantherSsd = "SsdStorageApacerPanther";
        string cougarPowerUnit = "CougarPowerUnit";
        string depxWiFi = "DexpWiFiAdapter";
        IMyBuilder computerOneBuilder = new MyBuilder();
        MyComputer myComputer = computerOneBuilder.WithCase((IComputerCase?)computerRepository.FindMyDetail(ardorCase))
            .WithCooler((ICooler?)computerRepository.FindMyDetail(coolerIdCooling))
            .WithGpu((IGpu?)computerRepository.FindMyDetail(msiGeForceGpu))
            .WithCpu((IMyСpu?)computerRepository.FindMyDetail(amdAthlon))
            .WithHdd((IHddStorage?)computerRepository.FindMyDetail(hddblue))
            .WithMotherboeard((IMotherboard?)computerRepository.FindMyDetail(asrockmotherboard))
            .WithRam((IRam?)computerRepository.FindMyDetail(adataRam))
            .WithSdd((ISsdStorage?)computerRepository.FindMyDetail(apacerPantherSsd))
            .WithPowerUnit((IPowerUnit?)computerRepository.FindMyDetail(cougarPowerUnit))
            .WithWiFiAdapter((IWiFiAdapter?)computerRepository.FindMyDetail(depxWiFi)).CreateComputer();
        var computerService = new MyComputerService(myComputer);
        Assert.Equal(elementSuccess, computerService.IsSocketRight());
        Assert.Equal(elementSuccess, computerService.IsCaseFormFactorRightToMotherboard());
        Assert.Equal(elementSuccess, computerService.IsCaseLengthRight());
        Assert.Equal(elementSuccess, computerService.IsBiosRight());
        Assert.Equal(elementSuccess, computerService.IsDdrStandardRight());
        Assert.Equal(processorTdpIsBiggerThenCoolerTdp, computerService.IsTdpCoolerEnough());
        Assert.Equal(elementSuccess, computerService.IsSsdRight());
        Assert.Equal(elementSuccess, computerService.IsHddRight());
        Assert.Equal(elementSuccess, computerService.IsPowerCapacityEnough());
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
        MyComputer myComputer = computerOneBuilder.WithCase((IComputerCase?)computerRepository.FindMyDetail(ardorCase))
            .WithCooler((ICooler?)computerRepository.FindMyDetail(coolerIdCooling))
            .WithGpu((IGpu?)computerRepository.FindMyDetail(msiGeForceGpu))
            .WithCpu((IMyСpu?)computerRepository.FindMyDetail(amdAthlon))
            .WithHdd((IHddStorage?)computerRepository.FindMyDetail(hddblue))
            .WithMotherboeard((IMotherboard?)computerRepository.FindMyDetail(asrockmotherboard))
            .WithRam((IRam?)computerRepository.FindMyDetail(adataRam))
            .WithSdd((ISsdStorage?)computerRepository.FindMyDetail(apacerPantherSsd))
            .WithPowerUnit((IPowerUnit?)computerRepository.FindMyDetail(cougarPowerUnit))
            .WithWiFiAdapter((IWiFiAdapter?)computerRepository.FindMyDetail(depxWiFi)).CreateComputer();
        var computerService = new MyComputerService(myComputer);
        Assert.Equal(socketIsNotSuitable, computerService.IsSocketRight());
        Assert.Equal(elementSuccess, computerService.IsCaseFormFactorRightToMotherboard());
        Assert.Equal(elementSuccess, computerService.IsCaseLengthRight());
        Assert.Equal(elementSuccess, computerService.IsBiosRight());
        Assert.Equal(elementSuccess, computerService.IsDdrStandardRight());
        Assert.Equal(elementSuccess, computerService.IsTdpCoolerEnough());
        Assert.Equal(elementSuccess, computerService.IsSsdRight());
        Assert.Equal(elementSuccess, computerService.IsHddRight());
        Assert.Equal(elementSuccess, computerService.IsPowerCapacityEnough());
    }
}