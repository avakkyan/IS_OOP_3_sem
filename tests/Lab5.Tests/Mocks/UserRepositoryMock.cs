using Itmo.ObjectOrientedProgramming.Lab5.Tests.Mocks;

namespace Lab5.Infastructure.DataAccess.Repositories;

public class UserRepositoryMock
{
    private readonly UserDataBase userMock = new UserDataBase();
    public decimal? CheckAccountBalance(string? name, string password)
    {
        decimal? value = userMock.GetBalance(name, password);
        return value;
    }

    public void CreateBankAccount(string name, string password)
    {
        userMock.AddUser(name, password, 0);
    }

    public void RefillMoneyOnAccount(string username, string password, decimal amount)
    {
        userMock.ChancgeBalance(username, password, amount);
    }
}