using Lab5.Application.Contracts.Admins;
using Spectre.Console;

namespace Lab5.Presentation.Scenarios;

public class AdminLoginScenario : IScenario
{
    private readonly IAdminService _adminService;
    private readonly AdminLowScenarioRunner _lowScenarioRunner;

    public AdminLoginScenario(IAdminService adminService, AdminLowScenarioRunner lowScenarioRunner)
    {
        _adminService = adminService;
        _lowScenarioRunner = lowScenarioRunner;
    }

    public string Name => "Log in Admin";

    public void Run()
    {
        string name = AnsiConsole.Ask<string>("Enter admin name");
        string password = AnsiConsole.Ask<string>("Enter password");
        _adminService.Login(name, password);
        _lowScenarioRunner.Run();
    }
}