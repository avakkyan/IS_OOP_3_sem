using Spectre.Console;
using Workshop5.Application.Contracts.Users;

namespace Lab5.Presentation.Scenarios;

public class AddUserAccountScenario : IScenario
{
    private readonly IUserService _userService;

    public AddUserAccountScenario(IUserService shopService)
    {
        _userService = shopService;
    }

    public string Name => "Add user account";

    public void Run()
    {
        string name = AnsiConsole.Ask<string>("Enter name");
        string password = AnsiConsole.Ask<string>("Enter password");
        _userService.CreateBankAccount(name, password);

        // var selector = new SelectionPrompt<Shop>()
        //     .Title("Select shop")
        //     .AddChoices(shops)
        //     .UseConverter(x => x.Name);

        // var shop = AnsiConsole.Prompt(selector);

        // AnsiConsole.WriteLine($"You selected {shop.Name}");
        // AnsiConsole.Ask<string>("");
    }
}