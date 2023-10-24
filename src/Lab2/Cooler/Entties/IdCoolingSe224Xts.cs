using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class IdCoolingSe224Xts : ICoolingIdCooler, ICloneable
{
    private const double _deepcoolGammaxx300Dimensions = 1359000;
    private const int _deepcoolGammaxx300TDP = 220;
    private IList<MySocket> _socketList = new List<MySocket>();

    public IdCoolingSe224Xts()
    {
        CoolerDimensions = _deepcoolGammaxx300Dimensions;
        CoolerTdp = _deepcoolGammaxx300TDP;
        _socketList.Add(new MySocketAm4());
        CoolerSocket = _socketList;
    }

    public double CoolerDimensions { get; private set; }
    public int CoolerTdp { get; private set; }
    public IList<MySocket> CoolerSocket { get; private set;  }

    public IdCoolingSe224Xts UpdateCoolerDimension(double coolerDimension)
    {
        var idCoolingSe224Xts = (IdCoolingSe224Xts)Clone();
        idCoolingSe224Xts.CoolerDimensions = coolerDimension;
        return idCoolingSe224Xts;
    }

    public IdCoolingSe224Xts UpdateCoolerTdp(int coolerTdp)
    {
        var idCoolingSe224Xts = (IdCoolingSe224Xts)Clone();
        idCoolingSe224Xts.CoolerTdp = coolerTdp;
        return idCoolingSe224Xts;
    }

    public IdCoolingSe224Xts UpdateCoolerTdp(IList<MySocket> coolerSocket)
    {
        var idCoolingSe224Xts = (IdCoolingSe224Xts)Clone();
        idCoolingSe224Xts.CoolerSocket = coolerSocket;
        return idCoolingSe224Xts;
    }

    public object Clone()
    {
        return new IdCoolingSe224Xts();
    }
}