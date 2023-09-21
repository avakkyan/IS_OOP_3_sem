using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

public interface IShipService
{
    public Ship ChooseOptimalShip(Route route, IReadOnlyCollection<Ship> ships);
    public void PassRoute(Route route, Ship ship);
}