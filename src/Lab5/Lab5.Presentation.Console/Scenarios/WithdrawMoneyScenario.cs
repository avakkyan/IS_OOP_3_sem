using Spectre.Console;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios;

public class WithdrawMoneyScenario : ILowScenario
{
    private readonly IUserService _userService;

    public WithdrawMoneyScenario(IUserService shopService)
    {
        _userService = shopService;
    }

    public string Name => "Withdraw money";

    public void Run()
    {
        int amount = AnsiConsole.Ask<int>("How much money would you like to withdraw?");
        _userService.WithdrawMoneyFromAccount(amount);

        // var selector = new SelectionPrompt<Shop>()
        //     .Title("Select shop")
        //     .AddChoices(shops)
        //     .UseConverter(x => x.Name);

        // var shop = AnsiConsole.Prompt(selector);

        // AnsiConsole.WriteLine($"You selected {shop.Name}");
        // AnsiConsole.Ask<string>("");
    }
}