using Itmo.ObjectOrientedProgramming.Lab1.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class CosmoWhale : IObstacle
{
    private const int CosmoWhaleDamage = 400;
    public CosmoWhale()
    {
        Damage = CosmoWhaleDamage;
    }

    public int Damage { get; set; }
    public void Hit()
    {
        throw new System.NotImplementedException();
    }
}