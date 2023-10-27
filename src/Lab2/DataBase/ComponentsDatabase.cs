using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Factory;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Factory;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase;

public class ComponentsDatabase
{
    private IList<IComputerDetail> _componentId = new List<IComputerDetail>();
    private ArdorFactory _ardorFactory = new ArdorFactory();
    private CougarFactory _cougarFactory = new CougarFactory();
    private CoolingIdFactory _coolingIdFactory = new CoolingIdFactory();
    private DeepcoolFactory _deepcoolFactory = new DeepcoolFactory();
    private CpuFourCoresFactory _cpuFourCoresFactory = new CpuFourCoresFactory();
    private CpuTwoCoresFactory _cpuTwoCoresFactory = new CpuTwoCoresFactory();
    private GpuEightMemoryFactory _gpuEightMemoryFactory = new GpuEightMemoryFactory();
    private GpuTwelveMemoryFactory _gpuTwelveMemoryFactory = new GpuTwelveMemoryFactory();
    private CougarPowerUnitFactory _cougarPowerUnitFactory = new CougarPowerUnitFactory();
    private DeepcoolPowerUnitFactory _deepcoolPowerUnitFactory = new DeepcoolPowerUnitFactory();
    private AdataXmpFactory _adataXmpFactory = new AdataXmpFactory();
    private KingstonRamFactory _kingstonRamFactory = new KingstonRamFactory();
    private HddStorageFactory _hddStorageFactory = new HddStorageFactory();
    private SsdStorageFacroty _ssdStorageFacroty = new SsdStorageFacroty();
    private DepxFactory _depxFactory = new DepxFactory();
    private TpLinkArcherFactory _tpLinkArcherFactory = new TpLinkArcherFactory();
    private AsrockMotherboardFactory _asrockMotherboardFactory = new AsrockMotherboardFactory();
    private BiostarMotherboardFactory _biostarMotherboardFactory = new BiostarMotherboardFactory();
    private GigabyteMotherboardFactory _gigabyteMotherboardFactory = new GigabyteMotherboardFactory();
    public ComponentsDatabase()
    {
        _componentId.Add(_cpuTwoCoresFactory.CreateIntelCpu());
        _componentId.Add(_cpuFourCoresFactory.CreateIntelCpu());
        _componentId.Add(_cpuFourCoresFactory.CreateAmdCpu());
        _componentId.Add(_cpuTwoCoresFactory.CreateAmdCpu());
        _componentId.Add(_deepcoolFactory.CreateCooler());
        _componentId.Add(_coolingIdFactory.CreateCooler());
        _componentId.Add(_ardorFactory.CreateComputerCase());
        _componentId.Add(_cougarFactory.CreateComputerCase());
        _componentId.Add(_gigabyteMotherboardFactory.CreateMotherboard());
        _componentId.Add(_gpuEightMemoryFactory.CreateGeForceGpu());
        _componentId.Add(_gpuTwelveMemoryFactory.CreateAmdGpu());
        _componentId.Add(_cougarPowerUnitFactory.CreatePowerUnit());
        _componentId.Add(_deepcoolPowerUnitFactory.CreatePowerUnit());
        _componentId.Add(_adataXmpFactory.CreateRam());
        _componentId.Add(_kingstonRamFactory.CreateRam());
        _componentId.Add(_hddStorageFactory.CreateStorage());
        _componentId.Add(_ssdStorageFacroty.CreateStorage());
        _componentId.Add(_depxFactory.CreateWiFiAdapter());
        _componentId.Add(_tpLinkArcherFactory.CreateWiFiAdapter());
        _componentId.Add(_asrockMotherboardFactory.CreateMotherboard());
        _componentId.Add(_biostarMotherboardFactory.CreateMotherboard());
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