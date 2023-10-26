using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.CPU.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios.Entities;

public class AwardBios : IBios, ICloneable
{
    private const int _awardBiosType = 1;
    private const double _awardBiosVersion = 1.14;
    private IList<IMyСpu> _awardCpuList = new List<IMyСpu>();

    public AwardBios()
    {
        BiosType = _awardBiosType;
        BiosVersion = _awardBiosVersion;
        _awardCpuList.Add(new CpuAmd5Ryzen());
        _awardCpuList.Add(new CpuAmdAthlon());
        CpuList = _awardCpuList;
    }

    public int BiosType { get; private set; }
    public double BiosVersion { get; private set; }
    public IList<IMyСpu> CpuList { get; private set; }

    public AwardBios UpdateBiosType(int biosType)
    {
        var awardBios = (AwardBios)Clone();
        awardBios.BiosType = biosType;
        return awardBios;
    }

    public AwardBios UpdateBiosVersion(int biosVersion)
    {
        var awardBios = (AwardBios)Clone();
        awardBios.BiosVersion = biosVersion;
        return awardBios;
    }

    public AwardBios UpdateCpuList(IList<IMyСpu> cpuList)
    {
        var awardBios = (AwardBios)Clone();
        awardBios.CpuList = cpuList;
        return awardBios;
    }

    public object Clone()
    {
        return new AmiBios();
    }
}