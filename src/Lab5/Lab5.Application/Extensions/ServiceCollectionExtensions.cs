using ConsoleApp2.OperationDetail;
using ConsoleApp2.Users;
using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Users;
using Microsoft.Extensions.DependencyInjection;
using Workshop5.Application.Contracts.Users;
using Workshop5.Application.Users;

namespace Lab5.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IUserService, UserService>();
        collection.AddScoped<IAdminService, AdminService>();

        collection.AddScoped<CurrentUserManager>();
        collection.AddScoped<ICurrentUserService>(
            p => p.GetRequiredService<CurrentUserManager>());

        collection.AddScoped<CurrentAdminManager>();
        collection.AddScoped<ICurrentAdminService>(
            p => p.GetRequiredService<CurrentAdminManager>());
        return collection;
    }
}