using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Users;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios.Login;

public class CheckAccountBalanceProvider : ILowScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;

    public CheckAccountBalanceProvider(IUserService service, ICurrentUserService currentUser)
    {
        _service = service;
        _currentUser = currentUser;
    }

    public bool TryGetScenario([NotNullWhen(true)] out ILowScenario scenario)
    {
        scenario = new CheckAccountBalanceScenario(_service);
        return true;
    }
}