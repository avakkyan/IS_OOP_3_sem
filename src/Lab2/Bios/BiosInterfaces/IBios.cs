using Itmo.ObjectOrientedProgramming.Lab2.Socket.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios.BiosInterfaces;

public interface IBios
{
    int BiosType { get; }
    double BiosVersion { get; }
    MySocket MyCpuSocket { get; }
    bool CheckBios();
}