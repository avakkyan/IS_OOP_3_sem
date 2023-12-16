using Spectre.Console;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios;

public class RefillMoneyScenario : ILowScenario
{
    private readonly IUserService _userService;

    public RefillMoneyScenario(IUserService shopService)
    {
        _userService = shopService;
    }

    public string Name => "Refill money";

    public void Run()
    {
        int amount = AnsiConsole.Ask<int>("How much money would you like to refill?");
        _userService.RefillMoneyOnAccount(amount);
    }
}