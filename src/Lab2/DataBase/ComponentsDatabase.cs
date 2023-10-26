using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCase.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.GPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.Storage.Entites;
using Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapter.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Мotherboard.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.DataBase;

public class ComponentsDatabase
{
    private IList<IComputerDetail> _componentId = new List<IComputerDetail>();
    public ComponentsDatabase()
    {
        _componentId.Add(new CpuIntelCorei3());
        _componentId.Add(new CpuIntelCorei5());
        _componentId.Add(new CpuAmd5Ryzen());
        _componentId.Add(new CpuAmdAthlon());
        _componentId.Add(new CoolerDeepcool());
        _componentId.Add(new CoolerIdCooling());
        _componentId.Add(new ArdorGamingCase());
        _componentId.Add(new SapphireAmdGpu());
        _componentId.Add(new GigabyteGeForceGpu());
        _componentId.Add(new MsiGeForceGpu());
        _componentId.Add(new PowerColorAmdGpu());
        _componentId.Add(new CougarPowerUnit());
        _componentId.Add(new DeepcoolPowerUnit());
        _componentId.Add(new AdataRam());
        _componentId.Add(new KingstonRam());
        _componentId.Add(new HddStorageWdBlue());
        _componentId.Add(new SsdStorageApacerPanther());
        _componentId.Add(new DexpWiFiAdapter());
        _componentId.Add(new TpLinkArcherWiFiAdapter());
        _componentId.Add(new AsrockMotherboard());
        _componentId.Add(new BiostarMotherboard());
        _componentId.Add(new GigabyteMotherboard());
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