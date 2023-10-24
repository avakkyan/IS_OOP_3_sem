using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class IdCoolingSe224Xts : ICoolingIdCooler
{
    private const double _DeepcoolGammaxx300Dimensions = 1359000;
    private const int _DeepcoolGammaxx300TDP = 220;
    private IList<MySocket> _socketList = new List<MySocket>();

    public IdCoolingSe224Xts()
    {
        CoolerDimensions = _DeepcoolGammaxx300Dimensions;
        CoolerTDP = _DeepcoolGammaxx300TDP;
        _socketList.Add(new MySocketAm4());
        CoolerSocket = _socketList;
    }

    public double CoolerDimensions { get; }
    public int CoolerTDP { get; }
    public IList<MySocket> CoolerSocket { get; }
}