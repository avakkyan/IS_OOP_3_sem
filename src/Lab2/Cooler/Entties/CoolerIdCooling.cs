using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class CoolerIdCooling : ICoolingIdCooler, ICloneable
{
    private const double _idCoolingimensions = 1359000;
    private const int _idCoolingTDP = 220;
    private const string _idCoolingName = "CoolerIdCooling";
    private const int _idCoolingPowerConsumtion = 15;
    private IList<MySocket> _socketList = new List<MySocket>();

    public CoolerIdCooling()
    {
        CoolerDimensions = _idCoolingimensions;
        CoolerTdp = _idCoolingTDP;
        Name = _idCoolingName;
        PowerConsumption = _idCoolingPowerConsumtion;
        _socketList.Add(new MySocketAm4());
        CoolerSocket = _socketList;
    }

    public double CoolerDimensions { get; private set; }
    public int CoolerTdp { get; private set; }
    public IList<MySocket> CoolerSocket { get; private set;  }
    public int PowerConsumption { get; private set; }
    public string Name { get; private set; }

    public CoolerIdCooling UpdateCoolerDimension(double coolerDimension)
    {
        var idCoolingSe224Xts = (CoolerIdCooling)Clone();
        idCoolingSe224Xts.CoolerDimensions = coolerDimension;
        return idCoolingSe224Xts;
    }

    public CoolerIdCooling UpdateCoolerTdp(int coolerTdp)
    {
        var idCoolingSe224Xts = (CoolerIdCooling)Clone();
        idCoolingSe224Xts.CoolerTdp = coolerTdp;
        return idCoolingSe224Xts;
    }

    public CoolerIdCooling UpdateCoolerTdp(IList<MySocket> coolerSocket)
    {
        var idCoolingSe224Xts = (CoolerIdCooling)Clone();
        idCoolingSe224Xts.CoolerSocket = coolerSocket;
        return idCoolingSe224Xts;
    }

    public CoolerIdCooling UpdatePowerConsumption(int powerConsumption)
    {
        var idCoolingSe224Xts = (CoolerIdCooling)Clone();
        idCoolingSe224Xts.PowerConsumption = powerConsumption;
        return idCoolingSe224Xts;
    }

    public CoolerIdCooling UpdatePowerName(string name)
    {
        var idCoolingSe224Xts = (CoolerIdCooling)Clone();
        idCoolingSe224Xts.Name = name;
        return idCoolingSe224Xts;
    }

    public object Clone()
    {
        return new CoolerIdCooling();
    }
}