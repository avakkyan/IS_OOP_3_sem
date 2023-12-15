using Lab5.Application.Models.Admins;

namespace Lab5.Application.Contracts.Users;

public interface ICurrentAdminService
{
    Admin? Admin { get; }
}