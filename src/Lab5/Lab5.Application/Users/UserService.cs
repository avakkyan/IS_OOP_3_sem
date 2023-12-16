using Lab5.Application.Abstraction.Repositories;
using Lab5.Application.Contracts.Users;
using Lab5.Application.Models.OperationsDetail;
using Lab5.Application.Models.Users;
using Workshop5.Application.Contracts.Users;
using Workshop5.Application.Users;

namespace ConsoleApp2.Users;

internal class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IOperationDetailRepository _detailRepository;
    private readonly CurrentUserManager _currentUserManager;

    public UserService(IUserRepository repository, CurrentUserManager currentUserManager, IOperationDetailRepository detailRepository)
    {
        _repository = repository;
        _currentUserManager = currentUserManager;
        _detailRepository = detailRepository;
    }

    public LoginResult Login(int userId, string password)
    {
        User? user = _repository.FindUserByUsernameAndPassword(userId, password);

        if (user is null)
        {
            return LoginResult.NotFound;
        }

        _currentUserManager.User = user;
        return LoginResult.Success;
    }

    public long? CheckAccountBalance()
    {
        long? balance = _repository.CheckAccountBalance(_currentUserManager.User?.Id);
        return balance;
    }

    public void CreateBankAccount(string name, string password)
    {
        _repository.CreateBankAccount(name, password);
    }

    public WithdrawMoneyResult WithdrawMoneyFromAccount(decimal amount)
    {
        _detailRepository.UpdateOperationInformation(_currentUserManager.User?.Id, -amount);
        return _repository.WithdrawMoneyFromAccount(_currentUserManager.User?.Id, amount);
    }

    public RefillMoneyResult RefillMoneyOnAccount(decimal amount)
    {
        _detailRepository.UpdateOperationInformation(_currentUserManager.User?.Id, amount);
        return _repository.RefillMoneyOnAccount(amount);
    }
}