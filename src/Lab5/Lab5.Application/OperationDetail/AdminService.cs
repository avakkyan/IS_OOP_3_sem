using Lab5.Application.Abstraction.Repositories;
using Lab5.Application.Contracts.Admins;
using Lab5.Application.Contracts.Users;
using Lab5.Application.Models.Admins;

namespace ConsoleApp2.OperationDetail;

internal class AdminService : IAdminService
{
    private readonly AdminData _adminData = new AdminData();
    private readonly CurrentAdminManager _currentAdminManager;
    private readonly IOperationDetailRepository _repository;

    public AdminService(IOperationDetailRepository repository, CurrentAdminManager currentAdminManager)
    {
        _repository = repository;
        _currentAdminManager = currentAdminManager;
    }

    public LoginResult Login(string name, string password)
    {
        if (name == _adminData.Name && password == _adminData.Password)
        {
            _currentAdminManager.Admin = new Admin(name, password);
            return LoginResult.Success;
        }

        return LoginResult.NotFound;
    }

    public IEnumerable<Lab5.Application.Models.OperationsDetail.OperationDetail> GetAllOperationDetails()
    {
        return _repository.GetAllOperation();
    }
}