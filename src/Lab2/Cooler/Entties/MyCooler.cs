using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class MyCooler : ICooler
{
    public MyCooler(
        double dimensions,
        int coolerTDP,
        string name,
        int powerConsumption,
        IList<MySocket> socketList)
    {
        CoolerDimensions = dimensions;
        CoolerTdp = coolerTDP;
        Name = name;
        PowerConsumption = powerConsumption;
        CoolerSocket = socketList;
    }

    public double CoolerDimensions { get; private set; }
    public int CoolerTdp { get; private set; }
    public IList<MySocket> CoolerSocket { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public MyCooler UpdateCoolerDimension(double coolerDimension)
    {
        var cooler = (MyCooler)Clone();
        cooler.CoolerDimensions = coolerDimension;
        return cooler;
    }

    public MyCooler UpdateCoolerTdp(int coolerTdp)
    {
        var cooler = (MyCooler)Clone();
        cooler.CoolerTdp = coolerTdp;
        return cooler;
    }

    public MyCooler UpdateCoolerTdp(IList<MySocket> coolerSocket)
    {
        var cooler = (MyCooler)Clone();
        cooler.CoolerSocket = coolerSocket;
        return cooler;
    }

    public MyCooler UpdatePowerConsumption(int powerConsumption)
    {
        var cooler = (MyCooler)Clone();
        cooler.PowerConsumption = powerConsumption;
        return cooler;
    }

    public MyCooler UpdatePowerName(int name)
    {
        var cooler = (MyCooler)Clone();
        cooler.PowerConsumption = name;
        return cooler;
    }

    public object Clone()
    {
        return new MyCooler(
            CoolerDimensions,
            CoolerTdp,
            Name,
            PowerConsumption,
            CoolerSocket);
    }
}