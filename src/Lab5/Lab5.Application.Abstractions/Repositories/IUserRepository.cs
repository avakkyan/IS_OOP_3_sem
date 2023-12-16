using Lab5.Application.Models.OperationsDetail;
using Lab5.Application.Models.Users;

namespace Lab5.Application.Abstraction.Repositories;

public interface IUserRepository
{
    User? FindUserByUsernameAndPassword(int userId, string password);
    long? CheckAccountBalance(long? userId);
    void CreateBankAccount(string name, string password);
    WithdrawMoneyResult WithdrawMoneyFromAccount(long? password, decimal amount);
    RefillMoneyResult RefillMoneyOnAccount(decimal amount);
}