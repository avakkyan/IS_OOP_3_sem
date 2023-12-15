using Spectre.Console;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios;

public class UserLoginScenario : IScenario
{
    private readonly IUserService _userService;
    private readonly LowScenarioRunner _lowScenarioRunner;

    public UserLoginScenario(IUserService shopService, LowScenarioRunner lowScenarioRunner)
    {
        _userService = shopService;
        _lowScenarioRunner = lowScenarioRunner;
    }

    public string Name => "Log in User";

    public void Run()
    {
        int id = AnsiConsole.Ask<int>("Enter user id");
        string password = AnsiConsole.Ask<string>("Enter password");
        _userService.Login(id, password);
        while (true)
        {
            _lowScenarioRunner.Run();
        }
    }
}