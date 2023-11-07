using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.CoolerIntefaces;
using Itmo.ObjectOrientedProgramming.Lab2.Cooler.Entties;
using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cooler.Factory;

public class CoolingIdFactory : ICoolerFactory
{
    private IList<MySocket> _socketsList = new List<MySocket>();
    public ICooler CreateCooler(
        double dimensions,
        int coolerTDP,
        string name,
        int powerConsumption)
    {
        _socketsList.Add(new MySocketAm4());
        return new MyCooler(
            dimensions,
            coolerTDP,
            name,
            powerConsumption,
            _socketsList);
    }
}