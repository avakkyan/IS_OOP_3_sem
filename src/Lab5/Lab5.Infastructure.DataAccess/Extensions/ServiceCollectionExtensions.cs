using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Models;
using Lab5.Application.Abstraction.Repositories;
using Lab5.Infastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Infastructure.DataAccess.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureDataAccess(
        this IServiceCollection collection,
        Action<PostgresConnectionConfiguration> configuration)
    {
        collection.AddPlatformPostgres(builder => builder.Configure(configuration));
        collection.AddPlatformMigrations(typeof(ServiceCollectionExtensions).Assembly);

        collection.AddScoped<IUserRepository, UserRepository>();
        collection.AddScoped<IOperationDetailRepository, OperationDetailRepository>();

        return collection;
    }
}