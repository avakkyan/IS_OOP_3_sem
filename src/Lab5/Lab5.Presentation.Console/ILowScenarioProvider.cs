using System.Diagnostics.CodeAnalysis;

namespace Lab5.Presentation;

public interface ILowScenarioProvider
{
    bool TryGetScenario([NotNullWhen(true)] out ILowScenario? scenario);
}