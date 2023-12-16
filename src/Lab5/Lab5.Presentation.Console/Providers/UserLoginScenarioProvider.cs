using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Users;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios.Login;

public class UserLoginScenarioProvider : IScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;
    private readonly LowScenarioRunner _lowScenarioRunner;

    public UserLoginScenarioProvider(
        IUserService service,
        ICurrentUserService currentUser,
        LowScenarioRunner lowScenarioRunner)
    {
        _service = service;
        _currentUser = currentUser;
        _lowScenarioRunner = lowScenarioRunner;
    }

    public bool TryGetScenario([NotNullWhen(true)] out IScenario? scenario)
    {
        if (_currentUser.User is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new UserLoginScenario(_service, _lowScenarioRunner);
        return true;
    }
}