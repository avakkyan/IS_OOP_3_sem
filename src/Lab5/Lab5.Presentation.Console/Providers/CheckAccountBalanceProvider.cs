using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Users;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios.Login;

public class CheckAccountBalanceProvider : ILowScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;
    private int _balance;

    public CheckAccountBalanceProvider(IUserService service, ICurrentUserService currentUser, int balance)
    {
        _service = service;
        _currentUser = currentUser;
        _balance = balance;
    }

    public bool TryGetScenario([NotNullWhen(true)] out ILowScenario scenario)
    {
        scenario = new CheckAccountBalanceScenario(_service, _balance);
        return true;
    }
}