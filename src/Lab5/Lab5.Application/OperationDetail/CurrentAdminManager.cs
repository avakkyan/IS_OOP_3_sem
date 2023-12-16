using Lab5.Application.Contracts.Users;
using Lab5.Application.Models.Admins;

namespace ConsoleApp2.OperationDetail;

internal class CurrentAdminManager : ICurrentAdminService
{
    public Admin? Admin { get; set; }
}