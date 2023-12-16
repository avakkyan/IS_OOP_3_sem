using Spectre.Console;

namespace Lab5.Presentation;

public class LowScenarioRunner
{
    private readonly IEnumerable<ILowScenarioProvider> _providers;

    public LowScenarioRunner(IEnumerable<ILowScenarioProvider> providers)
    {
        _providers = providers;
    }

    public void Run()
    {
        IEnumerable<ILowScenario> scenarios = GetScenarios();

        SelectionPrompt<ILowScenario> selector = new SelectionPrompt<ILowScenario>()
            .Title("Select action")
            .AddChoices(scenarios)
            .UseConverter(x => x.Name);

        ILowScenario scenario = AnsiConsole.Prompt(selector);
        scenario.Run();
    }

    private IEnumerable<ILowScenario> GetScenarios()
    {
        foreach (ILowScenarioProvider provider in _providers)
        {
            if (provider.TryGetScenario(out ILowScenario? scenario))
                yield return scenario;
        }
    }
}