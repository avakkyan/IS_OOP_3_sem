using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class CoolerDeepcool : IDeepcoolCooler, ICloneable
{
    private const double _deepcoolDimensions = 1239687.35;
    private const int _deepcoolTDP = 10;
    private const string _deepcoolName = "CoolerDeepcool";
    private const int _deepcoolPowerConsumption = 10;
    private IList<MySocket> _socketList = new List<MySocket>();
    public CoolerDeepcool()
    {
        CoolerDimensions = _deepcoolDimensions;
        CoolerTdp = _deepcoolTDP;
        Name = _deepcoolName;
        PowerConsumption = _deepcoolPowerConsumption;
        _socketList.Add(new MySocketAm4());
        _socketList.Add(new MySocketLga1700());
        CoolerSocket = _socketList;
    }

    public double CoolerDimensions { get; private set; }
    public int CoolerTdp { get; private set; }
    public IList<MySocket> CoolerSocket { get; private set; }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public CoolerDeepcool UpdateCoolerDimension(double coolerDimension)
    {
        var coolerDeepcoolGammaxx300 = (CoolerDeepcool)Clone();
        coolerDeepcoolGammaxx300.CoolerDimensions = coolerDimension;
        return coolerDeepcoolGammaxx300;
    }

    public CoolerDeepcool UpdateCoolerTdp(int coolerTdp)
    {
        var coolerDeepcoolGammaxx300 = (CoolerDeepcool)Clone();
        coolerDeepcoolGammaxx300.CoolerTdp = coolerTdp;
        return coolerDeepcoolGammaxx300;
    }

    public CoolerDeepcool UpdateCoolerTdp(IList<MySocket> coolerSocket)
    {
        var coolerDeepcoolGammaxx300 = (CoolerDeepcool)Clone();
        coolerDeepcoolGammaxx300.CoolerSocket = coolerSocket;
        return coolerDeepcoolGammaxx300;
    }

    public CoolerDeepcool UpdatePowerConsumption(int powerConsumption)
    {
        var coolerDeepcoolGammaxx300 = (CoolerDeepcool)Clone();
        coolerDeepcoolGammaxx300.PowerConsumption = powerConsumption;
        return coolerDeepcoolGammaxx300;
    }

    public CoolerDeepcool UpdatePowerName(int name)
    {
        var coolerDeepcoolGammaxx300 = (CoolerDeepcool)Clone();
        coolerDeepcoolGammaxx300.PowerConsumption = name;
        return coolerDeepcoolGammaxx300;
    }

    public object Clone()
    {
        return new CoolerDeepcool();
    }
}