using Spectre.Console;

namespace Lab5.Presentation;

public class AdminLowScenarioRunner
{
    private readonly IEnumerable<IAdminLowScenarioProvider> _providers;

    public AdminLowScenarioRunner(IEnumerable<IAdminLowScenarioProvider> providers)
    {
        _providers = providers;
    }

    public void Run()
    {
        IEnumerable<IAdminLowScenario> scenarios = GetScenarios();

        SelectionPrompt<IAdminLowScenario> selector = new SelectionPrompt<IAdminLowScenario>()
            .Title("Select action")
            .AddChoices(scenarios)
            .UseConverter(x => x.Name);

        IAdminLowScenario scenario = AnsiConsole.Prompt(selector);
        scenario.Run();
    }

    private IEnumerable<IAdminLowScenario> GetScenarios()
    {
        foreach (IAdminLowScenarioProvider provider in _providers)
        {
            if (provider.TryGetScenario(out IAdminLowScenario? scenario))
                yield return scenario;
        }
    }
}