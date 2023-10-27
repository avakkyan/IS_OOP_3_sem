using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.CpuInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios.Entities;

public class AmiBios : IBios, ICloneable
{
    private const int _amiBiosType = 2;
    private const double _amiBiosVersion = 2.14;
    private IList<IMyСpu> _amiCpuList = new List<IMyСpu>();

    public AmiBios()
    {
        BiosType = _amiBiosType;
        BiosVersion = _amiBiosVersion;
        _amiCpuList.Add(new CpuIntelCorei3());
        _amiCpuList.Add(new CpuIntelCorei5());
        CpuList = _amiCpuList;
    }

    public int BiosType { get; private set; }
    public double BiosVersion { get; private set; }
    public IList<IMyСpu> CpuList { get; private set; }
    public bool CheckBios()
    {
        foreach (IMyСpu cpu in CpuList)
        {
            if (cpu is CpuIntelCorei5 || cpu is CpuIntelCorei3)
            {
                return true;
            }
        }

        return false;
    }

    public AmiBios UpdateBiosType(int biosType)
    {
        var amiBios = (AmiBios)Clone();
        amiBios.BiosType = biosType;
        return amiBios;
    }

    public AmiBios UpdateBiosVersion(int biosVersion)
    {
        var amiBios = (AmiBios)Clone();
        amiBios.BiosVersion = biosVersion;
        return amiBios;
    }

    public AmiBios UpdateCpuList(IList<IMyСpu> cpuList)
    {
        var amiBios = (AmiBios)Clone();
        amiBios.CpuList = cpuList;
        return amiBios;
    }

    public object Clone()
    {
        return new AmiBios();
    }
}