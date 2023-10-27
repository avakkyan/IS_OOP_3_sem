namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Interface;

public interface IComputerService
{
    public Result IsSocketRight();
    public Result IsCaseFormFactorRightToMotherboard();
    public Result IsCaseLengthRight();
    public Result IsBiosRight();
    public Result IsDdrStandardRight();
    public Result IsTdpCoolerEnough();
    public Result IsSsdRight();
    public Result IsHddRight();
    public Result IsPowerCapacityEnough();
}