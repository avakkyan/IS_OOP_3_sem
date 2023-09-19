namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class PhotonDeflector
{
    private const int InitialHitPoints = 3000;
    public PhotonDeflector()
    {
        HitPoints = InitialHitPoints;
    }

    public int HitPoints { get; set; }
}