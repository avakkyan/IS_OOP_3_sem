using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Tools;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Interfaces;

public interface IShipService
{
    public Ship ChooseOptimalShip(Routes.Entities.Route route, IReadOnlyCollection<Ship> ships);
    public Success PassRoute(Routes.Entities.Route route, Ship ship);
}