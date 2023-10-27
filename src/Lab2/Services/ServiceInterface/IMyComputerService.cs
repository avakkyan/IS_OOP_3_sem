namespace Itmo.ObjectOrientedProgramming.Lab2.Services.ServiceInterface;

public interface IMyComputerService
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