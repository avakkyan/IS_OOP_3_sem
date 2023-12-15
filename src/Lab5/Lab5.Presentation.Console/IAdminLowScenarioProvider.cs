using System.Diagnostics.CodeAnalysis;

namespace Lab5.Presentation;

public interface IAdminLowScenarioProvider
{
    bool TryGetScenario([NotNullWhen(true)] out IAdminLowScenario? scenario);
}