using Lab5.Presentation.Scenarios;
using Lab5.Presentation.Scenarios.Login;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Presentation.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<ScenarioRunner>();
        collection.AddScoped<LowScenarioRunner>();
        collection.AddScoped<AdminLowScenarioRunner>();

        collection.AddScoped<IScenarioProvider, UserLoginScenarioProvider>();
        collection.AddScoped<IScenarioProvider, AdminLoginScenarioProvider>();
        collection.AddScoped<IScenarioProvider, AddAccountProvider>();

        collection.AddScoped<ILowScenarioProvider, CheckAccountBalanceProvider>();
        collection.AddScoped<IAdminLowScenarioProvider, CheckOperationsDetailScenarioProvider>();
        collection.AddScoped<ILowScenarioProvider, RefillMoneyScenarioProvider>();
        collection.AddScoped<ILowScenarioProvider, WithdrawMoneyScenarioProvider>();
        return collection;
    }
}