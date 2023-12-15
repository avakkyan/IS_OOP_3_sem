using Lab5.Application.Contracts.Users;
using Lab5.Application.Models.OperationsDetail;

namespace Lab5.Application.Contracts.Admins;

public interface IAdminService
{
    LoginResult Login(string name, string password);
    IEnumerable<OperationDetail> GetAllOperationDetails();
}