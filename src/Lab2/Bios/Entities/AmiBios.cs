using System;
using Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios.Entities;

public class AmiBios : IBios, ICloneable
{
    private const int _amiBiosType = 2;
    private const double _amiBiosVersion = 2.14;
    private MySocket cpuSocket = new MySocketLga1700();

    public AmiBios()
    {
        BiosType = _amiBiosType;
        BiosVersion = _amiBiosVersion;
        MyCpuSocket = cpuSocket;
    }

    public int BiosType { get; private set; }
    public double BiosVersion { get; private set; }
    public MySocket MyCpuSocket { get; private set; }
    public bool CheckBios()
    {
        if (cpuSocket is MySocketLga1700)
        {
            return true;
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

    public object Clone()
    {
        return new AmiBios();
    }
}