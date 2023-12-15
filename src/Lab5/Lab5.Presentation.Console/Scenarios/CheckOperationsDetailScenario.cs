using Lab5.Application.Contracts.Admins;

namespace Lab5.Presentation.Scenarios;

public class CheckOperationsDetailScenario : IAdminLowScenario
{
    private readonly IAdminService _adminService;
    private yeld 

    public CheckOperationsDetailScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name => "Check All Operations details";

    public void Run()
    {
        _adminService.GetAllOperationDetails();
    }
}