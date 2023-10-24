using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class CoolerDeepcoolGammaxx300 : IDeepcoolCooler, ICloneable
{
    private const double _deepcoolGammaxx300Dimensions = 1239687.35;
    private const int _deepcoolGammaxx300TDP = 130;
    private IList<MySocket> _socketList = new List<MySocket>();
    public CoolerDeepcoolGammaxx300()
    {
        CoolerDimensions = _deepcoolGammaxx300Dimensions;
        CoolerTdp = _deepcoolGammaxx300TDP;
        _socketList.Add(new MySocketAm4());
        _socketList.Add(new MySocketLga1700());
        CoolerSocket = _socketList;
    }

    public double CoolerDimensions { get; private set; }
    public int CoolerTdp { get; private set; }
    public IList<MySocket> CoolerSocket { get; private set; }

    public CoolerDeepcoolGammaxx300 UpdateCoolerDimension(double coolerDimension)
    {
        var coolerDeepcoolGammaxx300 = (CoolerDeepcoolGammaxx300)Clone();
        coolerDeepcoolGammaxx300.CoolerDimensions = coolerDimension;
        return coolerDeepcoolGammaxx300;
    }

    public CoolerDeepcoolGammaxx300 UpdateCoolerTdp(int coolerTdp)
    {
        var coolerDeepcoolGammaxx300 = (CoolerDeepcoolGammaxx300)Clone();
        coolerDeepcoolGammaxx300.CoolerTdp = coolerTdp;
        return coolerDeepcoolGammaxx300;
    }

    public CoolerDeepcoolGammaxx300 UpdateCoolerTdp(IList<MySocket> coolerSocket)
    {
        var coolerDeepcoolGammaxx300 = (CoolerDeepcoolGammaxx300)Clone();
        coolerDeepcoolGammaxx300.CoolerSocket = coolerSocket;
        return coolerDeepcoolGammaxx300;
    }

    public object Clone()
    {
        return new IdCoolingSe224Xts();
    }
}