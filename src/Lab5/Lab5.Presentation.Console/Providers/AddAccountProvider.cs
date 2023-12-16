using System.Diagnostics.CodeAnalysis;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios.Login;

public class AddAccountProvider : IScenarioProvider
{
    private readonly IUserService _service;

    public AddAccountProvider(IUserService service)
    {
        _service = service;
    }

    public bool TryGetScenario([NotNullWhen(true)] out IScenario scenario)
    {
        scenario = new AddUserAccountScenario(_service);
        return true;
    }
}