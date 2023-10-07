using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Interfaces;

public interface IObstacle
{
    public int Damage { get; }

    public void Hit(Ship ship);
}