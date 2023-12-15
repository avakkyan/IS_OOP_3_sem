using System.Collections.Generic;
using Workshop5.Application.Users;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Mocks;

public class UserDataBase
{
    private readonly IList<UserTable> _users = new List<UserTable>();

    public UserDataBase()
    {
        string username = "karina";
        string password = "123";
        _users.Add(new UserTable(username, password, 0));
    }

    public void ChancgeBalance(string username, string password, decimal value)
    {
        foreach (UserTable data in _users)
        {
            if (data.Name == username && data.Password == password)
            {
                data.ChangeBalance(value);
                return;
            }
        }
    }

    public decimal? GetBalance(string? username, string password)
    {
        decimal? balance;
        foreach (UserTable data in _users)
        {
            if (data.Name == username && data.Password == password)
            {
                balance = data.Balance;
                return balance;
            }
        }

        return null;
    }

    public void AddUser(string name, string password, int balance)
    {
        _users.Add(new UserTable(name, password, balance));
    }
}