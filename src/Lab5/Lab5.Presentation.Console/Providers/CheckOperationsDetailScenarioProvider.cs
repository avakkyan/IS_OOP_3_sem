using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios;

public class CheckOperationsDetailScenarioProvider : IAdminLowScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentAdminService _currentUser;

    public CheckOperationsDetailScenarioProvider(IAdminService service, ICurrentAdminService currentAdmin)
    {
        _service = service;
        _currentUser = currentAdmin;
    }

    public bool TryGetScenario([NotNullWhen(true)] out IAdminLowScenario scenario)
    {
        scenario = new CheckOperationsDetailScenario(_service);
        return true;
    }
}