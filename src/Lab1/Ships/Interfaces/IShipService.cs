using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Interfaces;

public interface IShipService
{
    Ship ChooseOptimalShip(Routes.Entities.Route route, IReadOnlyCollection<Ship> ships);
    Result PassRoute(Routes.Entities.Route route, Ship ship);
}