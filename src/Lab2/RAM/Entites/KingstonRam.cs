using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Entites;

public class KingstonRam : IRam, ICloneable
{
    private const int _kingstonRamPowerConsumption = 2;
    private const int _kingstionRamMemory = 32;
    private const string _kingstonRamName = "KingstonRam";
    private IList<int> _kingstionRamFrequencyJedec = new List<int>();

    public KingstonRam()
    {
        PowerConsumption = _kingstonRamPowerConsumption;
        TotalMemoryCapacity = _kingstionRamMemory;
        Name = _kingstonRamName;
        _kingstionRamFrequencyJedec.Add(15);
        _kingstionRamFrequencyJedec.Add(15);
        _kingstionRamFrequencyJedec.Add(17);
        RamFrequencyJedec = _kingstionRamFrequencyJedec;
    }

    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public int TotalMemoryCapacity { get; private set; }
    public IList<int> RamFrequencyJedec { get; private set; }
    public KingstonRam UpdatePowerConsumption(int powerConsumption)
    {
        var kingstonFUurRam = (KingstonRam)Clone();
        kingstonFUurRam.PowerConsumption = powerConsumption;
        return kingstonFUurRam;
    }

    public KingstonRam UpdateTotalMemoryCapacity(int powerConsumption)
    {
        var kingstonFUurRam = (KingstonRam)Clone();
        kingstonFUurRam.TotalMemoryCapacity = powerConsumption;
        return kingstonFUurRam;
    }

    public KingstonRam UpdateRamFrequencyJedec(IList<int> ramFrequencyJedec)
    {
        var kingstonFUurRam = (KingstonRam)Clone();
        kingstonFUurRam.RamFrequencyJedec = ramFrequencyJedec;
        return kingstonFUurRam;
    }

    public KingstonRam UpdateRamName(string name)
    {
        var kingstonFUurRam = (KingstonRam)Clone();
        kingstonFUurRam.Name = name;
        return kingstonFUurRam;
    }

    public object Clone()
    {
        return new KingstonRam();
    }
}