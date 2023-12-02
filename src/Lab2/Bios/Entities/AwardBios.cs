using System;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios.Entities;

public class AwardBios : IBios, ICloneable
{
    private const int _awardBiosType = 1;
    private const double _awardBiosVersion = 1.14;
    private MySocket cpuSocket = new MySocketAm4();

    public AwardBios()
    {
        BiosType = _awardBiosType;
        BiosVersion = _awardBiosVersion;
        MyCpuSocket = cpuSocket;
    }

    public int BiosType { get; private set; }
    public double BiosVersion { get; private set; }
    public MySocket MyCpuSocket { get; private set; }
    public bool CheckBios()
    {
        if (cpuSocket is MySocketAm4)
        {
            return true;
        }

        return false;
    }

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

    public object Clone()
    {
        return new AmiBios();
    }
}