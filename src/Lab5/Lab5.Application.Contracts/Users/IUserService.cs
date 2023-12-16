using Lab5.Application.Contracts.Users;
using Lab5.Application.Models.OperationsDetail;

namespace Workshop5.Application.Contracts.Users;

public interface IUserService
{
    LoginResult Login(int userId, string password);
    long? CheckAccountBalance();
    void CreateBankAccount(string name, string password);
    WithdrawMoneyResult WithdrawMoneyFromAccount(decimal amount);
    RefillMoneyResult RefillMoneyOnAccount(decimal amount);
}