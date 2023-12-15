using Spectre.Console;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios;

public class CheckAccountBalanceScenario : ILowScenario
{
    private readonly IUserService _userService;
    private long? _balance;

    public CheckAccountBalanceScenario(IUserService shopService, int balance)
    {
        _userService = shopService;
        _balance = balance;
    }

    public string Name => "Check Account Balance";

    public void Run()
    {
        _balance = _userService.CheckAccountBalance();
        AnsiConsole.WriteLine($"{_balance}");
    }
}