using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Entites;

public class AdataRam : IRam, ICloneable
{
    private const int _adataRamPowerConsumption = 3;
    private const int _adataRamMemory = 32;
    private const string _adataRamName = "AdataRam";
    private const int _adataDdrStandard = 4;
    private IList<int> _adataRamFrequencyJedec = new List<int>();

    public AdataRam()
    {
        PowerConsumption = _adataRamPowerConsumption;
        TotalMemoryCapacity = _adataRamMemory;
        Name = _adataRamName;
        RamDdrStandard = _adataDdrStandard;
        _adataRamFrequencyJedec.Add(15);
        _adataRamFrequencyJedec.Add(15);
        _adataRamFrequencyJedec.Add(17);
        RamFrequencyJedec = _adataRamFrequencyJedec;
    }

    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }
    public int TotalMemoryCapacity { get; private set; }
    public int RamDdrStandard { get; private set; }
    public IList<int> RamFrequencyJedec { get; private set; }
    public AdataRam UpdatePowerConsumption(int powerConsumption)
    {
        var adataXegSprctrixD41Rg = (AdataRam)Clone();
        adataXegSprctrixD41Rg.PowerConsumption = powerConsumption;
        return adataXegSprctrixD41Rg;
    }

    public AdataRam UpdateTotalMemoryCapacity(int powerConsumption)
    {
        var adataXegSprctrixD41Rg = (AdataRam)Clone();
        adataXegSprctrixD41Rg.TotalMemoryCapacity = powerConsumption;
        return adataXegSprctrixD41Rg;
    }

    public AdataRam UpdateRamFrequencyJedec(IList<int> ramFrequencyJedec)
    {
        var adataXegSprctrixD41Rg = (AdataRam)Clone();
        adataXegSprctrixD41Rg.RamFrequencyJedec = ramFrequencyJedec;
        return adataXegSprctrixD41Rg;
    }

    public AdataRam UpdateRamName(string name)
    {
        var adataXegSprctrixD41Rg = (AdataRam)Clone();
        adataXegSprctrixD41Rg.Name = name;
        return adataXegSprctrixD41Rg;
    }

    public AdataRam UpdateRamDdr(int ddrStandard)
    {
        var adataXegSprctrixD41Rg = (AdataRam)Clone();
        adataXegSprctrixD41Rg.RamDdrStandard = ddrStandard;
        return adataXegSprctrixD41Rg;
    }

    public object Clone()
    {
        return new KingstonRam();
    }
}