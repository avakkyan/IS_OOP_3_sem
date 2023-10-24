using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Intefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;

public class CoolerDeepcoolGammaxx300 : IDeepcoolCooler
{
    private const double _deepcoolGammaxx300Dimensions = 1239687.35;
    private const int _deepcoolGammaxx300TDP = 130;
    private IList<MySocket> _socketList = new List<MySocket>();
    public CoolerDeepcoolGammaxx300()
    {
        CoolerDimensions = _deepcoolGammaxx300Dimensions;
        CoolerTDP = _deepcoolGammaxx300TDP;
        _socketList.Add(new MySocketAm4());
        _socketList.Add(new MySocketLga1700());
        CoolerSocket = _socketList;
    }

    public double CoolerDimensions { get; }
    public int CoolerTDP { get; }
    public IList<MySocket> CoolerSocket { get; }
}