using Lab5.Application.Contracts.Admins;
using Lab5.Application.Models.OperationsDetail;
using Spectre.Console;

namespace Lab5.Presentation.Scenarios;

public class CheckOperationsDetailScenario : IAdminLowScenario
{
    private readonly IAdminService _adminService;
    private IEnumerable<OperationDetail>? _operationHistory;

    public CheckOperationsDetailScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name => "Check All Operations details";

    public void Run()
    {
        _operationHistory = _adminService.GetAllOperationDetails();
        foreach (OperationDetail operationDetail in _operationHistory)
        {
            AnsiConsole.WriteLine($"{operationDetail.Account}, {operationDetail.ChangeValue}");
        }

        AnsiConsole.Ask<string>("end");
    }
}