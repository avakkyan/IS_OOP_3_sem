using Itmo.ObjectOrientedProgramming.Lab2.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Services.ServiceInterface;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class MyComputerService : IMyComputerService
{
    private MyComputer _myComputer;
    public MyComputerService(MyComputer myPc)
    {
        _myComputer = myPc;
    }

    public Result IsSocketRight()
    {
        if (_myComputer.ComputerCpu?.CpuSocket is not null &&
            _myComputer.ComputerMotherboard?.MotherboardSocket is not null)
        {
            if (!_myComputer.ComputerMotherboard.SocketCheck(_myComputer.ComputerCpu.CpuSocket))
            {
                return Result.SocketIsNotSuitable;
            }
        }
        else
        {
            return Result.ErrorIsComputerAssembly;
        }

        return Result.ElementSuccess;
    }

    public Result IsCaseFormFactorRightToMotherboard()
    {
        if (_myComputer.ComputerComputerCase?.FormFactorList is not null &&
            _myComputer.ComputerMotherboard?.MotherboardFormFactor is not null)
        {
            if (!_myComputer.ComputerComputerCase.CheckFormFactor())
            {
                return Result.FormFactorMotherboeardIsNotSuitableToCase;
            }
        }

        return Result.ElementSuccess;
    }

    public Result IsCaseLengthRight()
    {
        if (_myComputer.ComputerComputerCase?.CaseHeightForVideoCard is not null
            && _myComputer.ComputerGpu?.GpuHeight is not null)
        {
            if (_myComputer.ComputerComputerCase.CaseHeightForVideoCard < _myComputer.ComputerGpu.GpuHeight)
            {
                return Result.CaseLengthIsNotSuitableToViseoCard;
            }
        }
        else
        {
            return Result.ErrorIsComputerAssembly;
        }

        return Result.ElementSuccess;
    }

    public Result IsBiosRight()
    {
        if (_myComputer.ComputerMotherboard?.MotherboardBios?.CpuList is not null && _myComputer.ComputerCpu is not null)
        {
            if (!_myComputer.ComputerMotherboard.MotherboardBios.CheckBios())
            {
                return Result.BiosIsNotSuitable;
            }
        }
        else
        {
            return Result.ErrorIsComputerAssembly;
        }

        return Result.ElementSuccess;
    }

    public Result IsDdrStandardRight()
    {
        if (_myComputer.ComputerMotherboard?.MotherboardDdrStandard is not null &&
            _myComputer.ComputerRam?.RamDdrStandard is not null)
        {
            if (_myComputer.ComputerMotherboard.MotherboardDdrStandard != _myComputer.ComputerRam.RamDdrStandard)
            {
                return Result.DdrStandardIsNotSuitable;
            }
        }
        else
        {
            return Result.ErrorIsComputerAssembly;
        }

        return Result.ElementSuccess;
    }

    public Result IsTdpCoolerEnough()
    {
        if (_myComputer.ComputerCooler?.CoolerTdp is not null && _myComputer.ComputerCpu?.HeatRelease is not null)
        {
            if (_myComputer.ComputerCpu.HeatRelease > _myComputer.ComputerCooler.CoolerTdp)
            {
                return Result.ProcessorTdpIsBiggerThenCoolerTdp;
            }
        }

        return Result.ElementSuccess;
    }

    public Result IsSsdRight()
    {
        if (_myComputer.ComputerSsd?.SsdConnectionSata is not null &&
            _myComputer.ComputerMotherboard?.SataAmount is not null)
        {
            if (_myComputer.ComputerSsd.SsdConnectionSata != _myComputer.ComputerMotherboard.SataAmount)
            {
                return Result.SsdIsNotSuitable;
            }

            return Result.ElementSuccess;
        }

        if (_myComputer.ComputerSsd?.SsdConnectionPci is null && _myComputer.ComputerMotherboard?.PciExpressAmount is not null)
        {
            if (_myComputer.ComputerSsd?.SsdConnectionPci > 0 && _myComputer.ComputerMotherboard.PciExpressAmount == 0)
            {
                return Result.SsdIsNotSuitable;
            }
        }
        else
        {
            return Result.ErrorIsComputerAssembly;
        }

        return Result.ElementSuccess;
    }

    public Result IsHddRight()
    {
        if (_myComputer.ComputerHdd?.HddConnection is not null &&
            _myComputer.ComputerMotherboard?.SataAmount is not null)
        {
            if (_myComputer.ComputerHdd.HddConnection != _myComputer.ComputerMotherboard.SataAmount)
            {
                return Result.HddIsNotSuitable;
            }
        }
        else
        {
            return Result.ErrorIsComputerAssembly;
        }

        return Result.ElementSuccess;
    }

    public Result IsPowerCapacityEnough()
    {
        if (_myComputer.ComputerMotherboard?.PowerConsumption is not null &&
            _myComputer.ComputerSsd?.PowerConsumption is not null &&
            _myComputer.ComputerHdd?.PowerConsumption is not null &&
            _myComputer.ComputerCooler?.PowerConsumption is not null &&
            _myComputer.ComputerCooler?.PowerConsumption is not null &&
            _myComputer.ComputerCpu?.PowerConsumption is not null &&
            _myComputer.ComputerRam?.PowerConsumption is not null &&
            _myComputer.ComputerGpu?.PowerConsumption is not null &&
            _myComputer.ComputerWiFiAdapter?.PowerConsumption is not null &&
            _myComputer.ComputerPowerUnit?.PowerConsumption is not null &&
            _myComputer.ComputerPowerUnit?.PeakLoad is not null)
        {
            if (_myComputer.ComputerMotherboard?.PowerConsumption +
                _myComputer.ComputerSsd?.PowerConsumption +
                _myComputer.ComputerHdd?.PowerConsumption +
                _myComputer.ComputerCooler?.PowerConsumption +
                _myComputer.ComputerCooler?.PowerConsumption +
                _myComputer.ComputerCpu?.PowerConsumption +
                _myComputer.ComputerRam?.PowerConsumption +
                _myComputer.ComputerGpu?.PowerConsumption +
                _myComputer.ComputerWiFiAdapter?.PowerConsumption +
                _myComputer.ComputerPowerUnit?.PowerConsumption > _myComputer.ComputerPowerUnit?.PeakLoad)
            {
                return Result.PowerCapasicyIsNotEnough;
            }
        }
        else
        {
            return Result.ErrorIsComputerAssembly;
        }

        return Result.ElementSuccess;
    }
}