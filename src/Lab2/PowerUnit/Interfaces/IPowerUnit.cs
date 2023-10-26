using Itmo.ObjectOrientedProgramming.Lab2.DataBase;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerUnit.Interfaces;

public interface IPowerUnit : IComputerDetail
{
    int PeakLoad { get; }
}