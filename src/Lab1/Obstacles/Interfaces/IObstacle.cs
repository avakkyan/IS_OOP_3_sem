using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

public interface IObstacle
{
    double Damage { get; }

    void Hit(Ship ship);
}