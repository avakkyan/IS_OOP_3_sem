using Lab5.Infastructure.DataAccess.Repositories;
using Workshop5.Application.Users;

namespace ConsoleApp2.Users;

internal class UserServiceMock
{
    private readonly UserRepositoryMock _repository;
    private readonly CurrentUserManagerMock _currentUserManager;

    public UserServiceMock(UserRepositoryMock repository, CurrentUserManagerMock currentUserManager)
    {
        _repository = repository;
        _currentUserManager = currentUserManager;
    }

    public decimal? CheckAccountBalance()
    {
        if (_currentUserManager.User != null)
        {
            decimal? balance = _repository.CheckAccountBalance(
                _currentUserManager.User.Username,
                _currentUserManager.User.Password);
            return balance;
        }

        return null;
    }

    public void CreateBankAccount(string name, string password)
    {
        _repository.CreateBankAccount(name, password);
    }

    public void RefillMoneyOnAccount(decimal amount)
    {
        if (_currentUserManager.User != null)
        {
            _repository.RefillMoneyOnAccount(
                _currentUserManager.User.Username,
                _currentUserManager.User.Password,
                amount);
        }
    }
}