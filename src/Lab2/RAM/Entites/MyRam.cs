using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.RAM.RamInterfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAM.Entites;

public class MyRam : IRam, ICloneable
{
      public MyRam(
        int powerConsumption,
        int ramMemory,
        string name,
        int dDrStandard,
        IList<int> adataRamFrequencyJedec)
    {
        PowerConsumption = powerConsumption;
        TotalMemoryCapacity = ramMemory;
        Name = name;
        RamDdrStandard = dDrStandard;
        RamFrequencyJedec = adataRamFrequencyJedec;
    }

      public int PowerConsumption { get; private set; }
      public string Name { get; private set; }
      public int TotalMemoryCapacity { get; private set; }
      public int RamDdrStandard { get; private set; }
      public IList<int> RamFrequencyJedec { get; private set; }
      public MyRam UpdatePowerConsumption(int powerConsumption)
    {
        var myRam = (MyRam)Clone();
        myRam.PowerConsumption = powerConsumption;
        return myRam;
    }

      public MyRam UpdateTotalMemoryCapacity(int powerConsumption)
    {
        var myRam = (MyRam)Clone();
        myRam.TotalMemoryCapacity = powerConsumption;
        return myRam;
    }

      public MyRam UpdateRamFrequencyJedec(IList<int> ramFrequencyJedec)
    {
        var myRam = (MyRam)Clone();
        myRam.RamFrequencyJedec = ramFrequencyJedec;
        return myRam;
    }

      public MyRam UpdateRamName(string name)
    {
        var myRam = (MyRam)Clone();
        myRam.Name = name;
        return myRam;
    }

      public MyRam UpdateRamDdr(int ddrStandard)
    {
        var myRam = (MyRam)Clone();
        myRam.RamDdrStandard = ddrStandard;
        return myRam;
    }

      public object Clone()
    {
        return new MyRam(
            PowerConsumption,
            TotalMemoryCapacity,
            Name,
            RamDdrStandard,
            RamFrequencyJedec);
    }
}