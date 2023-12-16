using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Entities.WiFiStandard;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.WiFiStandard;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Factory;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase;

public class ComponentsDatabase
{
    private const int ArdorGamingHeight = 290;
    private const int ArdorGamingWidth = 150;
    private const int ArdorGamingCasePowerConsumption = 0;
    private const string ArdorGamingName = "ArdorGamingCase";

    private const int CougarDuofaceProRgbHeight = 390;
    private const int CougarDuofaceProRgbWidth = 150;
    private const int CougarDuofaceProRgbCasePowerConsumption = 0;
    private const string CougarDuofaceCaseName = "CougarDuofaceCase";

    private const double AthlonCoreFrequency = 3.2;
    private const int AthlonNumberOfCores = 2;
    private const int AthlonMemoryFrequencies = 4800;
    private const int AthlonHeatRelease = 35;
    private const string AthlonName = "CpuAmdAthlon";
    private const bool AthlonIsVideoCore = false;
    private const int AthlonPowerConsumption = 35;

    private const double RyzenCoreFrequency = 3.6;
    private const int RyzenNumberOfCores = 4;
    private const int RyzenMemoryFrequencies = 2933;
    private const int RyzenHeatRelease = 35;
    private const string RyzenName = "CpuAmd5Ryzen5";
    private const bool RyzenIsVideoCore = false;
    private const int RyzenPowerConsumption = 35;

    private const double I3CoreFrequency = 3.3;
    private const int I3NumberOfCores = 4;
    private const int I3MemoryFrequencies = 4800;
    private const int I3HeatRelease = 89;
    private const int I3PowerConsumption = 58;
    private const bool I3IsVideoCore = false;
    private const string I3Name = "CpuIntelCorei3";

    private const double I5CoreFrequency = 2.5;
    private const int I5NumberOfCores = 6;
    private const int I5MemoryFrequencies = 4800;
    private const int I5HeatRelease = 65;
    private const int I5PowerConsumption = 65;
    private const bool I5IsVideoCore = false;
    private const string I5Name = "CpuIntelCorei5";

    private const double IdCoolingimensions = 1359000;
    private const int IdCoolingTdp = 220;
    private const string IdCoolingName = "CoolerIdCooling";
    private const int IdCoolingPowerConsumtion = 15;

    private const double DeepcoolDimensions = 1239687.35;
    private const int DeepcoolTdp = 10;
    private const string DeepcoolName = "CoolerDeepcool";
    private const int DeepcoolPowerConsumption = 10;

    private const double GigabyteGeForceHeight = 261;
    private const double GigabyteGeForceWidth = 126;
    private const int GigabyteGeForceVideoMemoryCapacity = 12;
    private const double GigabyteGeForcePciEVersion = 4.0;
    private const int GigabyteGeForceChipFrequency = 1920;
    private const int GigabyteGeForcePowerConsumption = 200;
    private const string GigabyteGeForceName = "GigabyteGeForceGpu";

    private const double MsiGeForceRtxHeight = 199;
    private const double MsiGeForceRtxWidth = 120;
    private const int MsiGeForceRtxMemoryCapacity = 8;
    private const double MsiGeForceRtxPciEVersion = 4.0;
    private const int MsiGeForceRtxChipFrequency = 1830;
    private const int MsiGeForceRtxPowerConsumption = 115;
    private const string MsiGeForceName = "MsiGeForceGpu";

    private const double PowerColorAmdHeight = 294;
    private const double PowerColorAmdWidth = 118;
    private const int PowerColorAmdMemoryCapacity = 8;
    private const double PowerColorAmdPciEVersion = 4.0;
    private const int PowerColorAmdChipFrequency = 1410;
    private const int PowerColorAmdPowerConsumption = 225;
    private const string PowerColorAmdPowerName = "PowerColorAmdGpu";

    private const double SapphireAmdHeight = 260;
    private const double SapphireAmdWidth = 119.85;
    private const int SapphireAmdVideoMemoryCapacity = 12;
    private const double SapphireAmdPciEVersion = 4.0;
    private const int SapphireAmdChipFrequency = 2321;
    private const int SapphireAmdPowerConsumption = 230;
    private const string SapphireAmdName = "SapphireAmdGpu";

    private const int CougarPowerUnitPeakLoad = 800;
    private const int CougarPowerUnitPowerConsumtion = 0;
    private const string CougarPowerUnitName = "CougarPowerUnit";

    private const int DeepcoolpeakLoad = 100;
    private const int DeepcoolpowerConsumption = 0;
    private const string DeepcoolPowerUnitName = "DeepcoolPowerUnit";

    private const int AdataRamPowerConsumption = 3;
    private const int AdataRamMemory = 32;
    private const string AdataRamName = "AdataRam";
    private const int AdataDdrStandard = 4;

    private const int KingstonRamPowerConsumption = 2;
    private const int KingstionRamMemory = 32;
    private const int KingstonRamDdrStandard = 3;
    private const string KingstonRamName = "KingstonRam";

    private const int HhdWdBlueCapacity = 1000;
    private const double HhdWdBluePowerConsumption = 6.8;
    private const int HhdWdBlueSpindleRotationSpeed = 7200;
    private const string HhdWdBlueName = "HddStorageWdBlue";
    private const int HhdWdBlueConnection = 4;

    private const int SsdApacerPantherCapacity = 480;
    private const double SsdApacerPantherPowerConsumption = 6.8;
    private const int SsdApacerPantherMaximumOperatingSpeed = 241;
    private const int SsdConnectionPci = 0;
    private const string SsdApacerPantherName = "SsdStorageApacerPanther";
    private const int _ssdApacerPantherConnectionSata = 4;

    private const double DexpWiFiPciVersion = 4.0;
    private const int DexpWiFiAdapterPower = 20;
    private const string DexpWiFiAdapterName = "DexpWiFiAdapter";
    private const bool DepxisBluetoothModule = false;

    private const double TpLinkArcherWiFiPciEVersion = 4.0;
    private const int TpLinkArcherWiFiAdapterPower = 19;
    private const string TpLinkArcherWiFiAdapteName = "TpLinkArcherWiFiAdapter";
    private const bool TpLinkIsBluetoothModule = false;

    private const int AsrockPciExpressAmount = 0;
    private const int AsrockSataAmount = 4;
    private const int AsrockDdrStandart = 4;
    private const int AsrockRamTablesAmount = 2;
    private const int AsrockPowerConsumption = 40;
    private const int AsrockBiosType = 1;
    private const double AsrockbiosVersionType = 1.14;
    private const string AsrockRamName = "AsrockMotherboard";

    private const int BiostarPciExpressAmount = 1;
    private const int BiostarSataAmount = 4;
    private const int BiostarDdrStandart = 4;
    private const int BiostarRamTablesAmount = 2;
    private const int BiostarPowerConsumption = 39;
    private const int BiostarBiosType = 1;
    private const double BiostarbiosVersionType = 1.14;
    private const string BiostarName = "BiostarMotherboard";

    private const int GigabytePciExpressAmount = 1;
    private const int GigabyteSataAmount = 4;
    private const int GigabyteDdrStandart = 4;
    private const int GigabyteRamTablesAmount = 2;
    private const int GigabyteBiosType = 1;
    private const int GigabytePowerConsumption = 41;
    private const double GigabytebiosVersionType = 1.14;
    private const string GigabyteName = "GigabyteMotherboard";

    private IBios _asrockBios = new AmiBios();
    private MySocket _asrockSocket = new MySocketAm4();
    private MyChipset _asrockChipset = new ChipsetA320();

    private IBios _biosarBios = new AmiBios();
    private MySocket _biostarSocket = new MySocketAm4();
    private MyChipset _biostarChipset = new ChipsetA320();

    private IBios _gigabyteBios = new AmiBios();
    private MySocket _gigabyteSocket = new MySocketAm4();
    private MyChipset _gigabyteChipset = new ChipsetA320();

    private TypeWiFiStandard _tpLinkArcherWiFiStandart = new TypeWiFiStandard480211N();
    private TypeWiFiStandard _dexpWiFiAdapterStandart = new TypeWiFiStandard480211N();

    private IList<IComputerDetail> _componentId = new List<IComputerDetail>();
    private ComputerCaseAtxFactory _computerCaseAtxFactory = new ComputerCaseAtxFactory();
    private ComputerCaseAtxMicroFactory _computerCaseAtxMicroFactory = new ComputerCaseAtxMicroFactory();
    private CpuAm4Factory _cpuAm4Factory = new CpuAm4Factory();
    private CpuLga1700Factory _cpuLga1700Factory = new CpuLga1700Factory();
    private CoolingIdFactory _coolingIdFactory = new CoolingIdFactory();
    private DeepcoolFactory _deepcoolFactory = new DeepcoolFactory();
    private GpuFactory _gpuFactory = new GpuFactory();
    private PowerUnitFactory _powerUnitFactory = new PowerUnitFactory();
    private AdataXmpFactory _adataXmpFactory = new AdataXmpFactory();
    private KingstonRamFactory _kingstonRamFactory = new KingstonRamFactory();
    private HddStorageFactory _hddStorageFactory = new HddStorageFactory(HhdWdBlueSpindleRotationSpeed, HhdWdBlueConnection);
    private SsdStorageFacroty _ssdStorageFacroty = new SsdStorageFacroty(
        SsdApacerPantherMaximumOperatingSpeed,
        SsdConnectionPci,
        _ssdApacerPantherConnectionSata);
    private WiFiAdapterFactory _wiFiAdapterFactory = new WiFiAdapterFactory();

    private MotherboardAtxMicroFormFactorFactory _motherboardAtxMicroFormFactorFactory = new MotherboardAtxMicroFormFactorFactory();
    public ComponentsDatabase()
    {
        _componentId.Add(_computerCaseAtxFactory.CreateComputerCase(
            ArdorGamingHeight,
            ArdorGamingWidth,
            ArdorGamingCasePowerConsumption,
            ArdorGamingName));

        _componentId.Add(_computerCaseAtxMicroFactory.CreateComputerCase(
            CougarDuofaceProRgbHeight,
            CougarDuofaceProRgbWidth,
            CougarDuofaceProRgbCasePowerConsumption,
            CougarDuofaceCaseName));

        _componentId.Add(_cpuAm4Factory.CreateAmdCpu(
            AthlonCoreFrequency,
            AthlonNumberOfCores,
            AthlonMemoryFrequencies,
            AthlonHeatRelease,
            AthlonPowerConsumption,
            AthlonIsVideoCore,
            AthlonName));

        _componentId.Add(_cpuAm4Factory.CreateAmdCpu(
            RyzenCoreFrequency,
            RyzenNumberOfCores,
            RyzenMemoryFrequencies,
            RyzenHeatRelease,
            RyzenPowerConsumption,
            RyzenIsVideoCore,
            RyzenName));

        _componentId.Add(_cpuLga1700Factory.CreateAmdCpu(
            I3CoreFrequency,
            I3NumberOfCores,
            I3MemoryFrequencies,
            I3HeatRelease,
            I3PowerConsumption,
            I3IsVideoCore,
            I3Name));

        _componentId.Add(_cpuLga1700Factory.CreateAmdCpu(
            I5CoreFrequency,
            I5NumberOfCores,
            I5MemoryFrequencies,
            I5HeatRelease,
            I5PowerConsumption,
            I5IsVideoCore,
            I5Name));

        _componentId.Add(_coolingIdFactory.CreateCooler(
            IdCoolingimensions,
            IdCoolingTdp,
            IdCoolingName,
            IdCoolingPowerConsumtion));

        _componentId.Add(_deepcoolFactory.CreateCooler(
            DeepcoolDimensions,
            DeepcoolTdp,
            DeepcoolName,
            DeepcoolPowerConsumption));

        _componentId.Add(_gpuFactory.CreateGpu(
            GigabyteGeForceHeight,
            GigabyteGeForceWidth,
            GigabyteGeForceVideoMemoryCapacity,
            GigabyteGeForcePciEVersion,
            GigabyteGeForceChipFrequency,
            GigabyteGeForcePowerConsumption,
            GigabyteGeForceName));

        _componentId.Add(_gpuFactory.CreateGpu(
            MsiGeForceRtxHeight,
            MsiGeForceRtxWidth,
            MsiGeForceRtxMemoryCapacity,
            MsiGeForceRtxPciEVersion,
            MsiGeForceRtxChipFrequency,
            MsiGeForceRtxPowerConsumption,
            MsiGeForceName));

        _componentId.Add(_gpuFactory.CreateGpu(
            PowerColorAmdHeight,
            PowerColorAmdWidth,
            PowerColorAmdMemoryCapacity,
            PowerColorAmdPciEVersion,
            PowerColorAmdChipFrequency,
            PowerColorAmdPowerConsumption,
            PowerColorAmdPowerName));

        _componentId.Add(_gpuFactory.CreateGpu(
            SapphireAmdHeight,
            SapphireAmdWidth,
            SapphireAmdVideoMemoryCapacity,
            SapphireAmdPciEVersion,
            SapphireAmdChipFrequency,
            SapphireAmdPowerConsumption,
            SapphireAmdName));

        _componentId.Add(_powerUnitFactory.CreatePowerUnit(
            CougarPowerUnitPeakLoad,
            CougarPowerUnitPowerConsumtion,
            CougarPowerUnitName));

        _componentId.Add(_powerUnitFactory.CreatePowerUnit(
            DeepcoolpeakLoad,
            DeepcoolpowerConsumption,
            DeepcoolPowerUnitName));

        _componentId.Add(_adataXmpFactory.CreateRam(
            AdataRamPowerConsumption,
            AdataRamMemory,
            AdataRamName,
            AdataDdrStandard));

        _componentId.Add(_kingstonRamFactory.CreateRam(
            KingstonRamPowerConsumption,
            KingstionRamMemory,
            KingstonRamName,
            KingstonRamDdrStandard));

        _componentId.Add(_hddStorageFactory.CreateStorage(
            HhdWdBlueCapacity,
            HhdWdBluePowerConsumption,
            HhdWdBlueName));

        _componentId.Add(_ssdStorageFacroty.CreateStorage(
            SsdApacerPantherCapacity,
            SsdApacerPantherPowerConsumption,
            SsdApacerPantherName));

        _componentId.Add(_wiFiAdapterFactory.CreateWiFiAdapter(
            DepxisBluetoothModule,
            DexpWiFiPciVersion,
            DexpWiFiAdapterPower,
            DexpWiFiAdapterName,
            _dexpWiFiAdapterStandart));

        _componentId.Add(_wiFiAdapterFactory.CreateWiFiAdapter(
            DepxisBluetoothModule,
            DexpWiFiPciVersion,
            DexpWiFiAdapterPower,
            DexpWiFiAdapterName,
            _dexpWiFiAdapterStandart));

        _componentId.Add(_wiFiAdapterFactory.CreateWiFiAdapter(
            TpLinkIsBluetoothModule,
            TpLinkArcherWiFiPciEVersion,
            TpLinkArcherWiFiAdapterPower,
            TpLinkArcherWiFiAdapteName,
            _tpLinkArcherWiFiStandart));

        _componentId.Add(_motherboardAtxMicroFormFactorFactory.CreateMotherboard(
            AsrockPciExpressAmount,
            AsrockSataAmount,
            AsrockDdrStandart,
            AsrockRamTablesAmount,
            AsrockPowerConsumption,
            AsrockBiosType,
            AsrockbiosVersionType,
            AsrockRamName,
            _asrockBios,
            _asrockSocket,
            _asrockChipset));

        _componentId.Add(_motherboardAtxMicroFormFactorFactory.CreateMotherboard(
            BiostarPciExpressAmount,
            BiostarSataAmount,
            BiostarDdrStandart,
            BiostarRamTablesAmount,
            BiostarPowerConsumption,
            BiostarBiosType,
            BiostarbiosVersionType,
            BiostarName,
            _biosarBios,
            _biostarSocket,
            _biostarChipset));

        _componentId.Add(_motherboardAtxMicroFormFactorFactory.CreateMotherboard(
            GigabytePciExpressAmount,
            GigabyteSataAmount,
            GigabyteDdrStandart,
            GigabyteRamTablesAmount,
            GigabytePowerConsumption,
            GigabyteBiosType,
            GigabytebiosVersionType,
            GigabyteName,
            _gigabyteBios,
            _gigabyteSocket,
            _gigabyteChipset));
    }

    public IComputerDetail? FindDetail(string detailName)
    {
        return _componentId.FirstOrDefault(detail => detail.Name == detailName);
    }

    public void Update(IComputerDetail detail)
    {
        _componentId.Add(detail);
    }
}