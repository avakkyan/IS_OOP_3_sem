using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Users;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios;

public class RefillMoneyScenarioProvider : ILowScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;

    public RefillMoneyScenarioProvider(
        IUserService service,
        ICurrentUserService currentUser)
    {
        _service = service;
        _currentUser = currentUser;
    }

    public bool TryGetScenario([NotNullWhen(true)] out ILowScenario? scenario)
    {
        if (_currentUser.User is null)
        {
            scenario = null;
            return false;
        }

        scenario = new RefillMoneyScenario(_service);
        return true;
    }
}