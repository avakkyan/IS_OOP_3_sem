using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios.Login;

public class AdminLoginScenarioProvider : IScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentAdminService _currentAdmin;
    private readonly AdminLowScenarioRunner _lowScenarioRunner;

    public AdminLoginScenarioProvider(
        IAdminService service,
        ICurrentAdminService currentAdmin,
        AdminLowScenarioRunner lowScenarioRunner)
    {
        _service = service;
        _currentAdmin = currentAdmin;
        _lowScenarioRunner = lowScenarioRunner;
    }

    public bool TryGetScenario([NotNullWhen(true)] out IScenario? scenario)
    {
        if (_currentAdmin.Admin is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new AdminLoginScenario(_service, _lowScenarioRunner);
        return true;
    }
}