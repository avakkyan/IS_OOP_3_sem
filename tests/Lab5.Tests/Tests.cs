using ConsoleApp2.Users;
using Lab5.Infastructure.DataAccess.Repositories;
using Workshop5.Application.Users;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class Tests
{
    [Fact]
    public void CheckChangingBalance()
    {
        var userManagerMock = new CurrentUserManagerMock();
        var userRepositoryMock = new UserRepositoryMock();
        var userServiceMock = new UserServiceMock(userRepositoryMock, userManagerMock);
        userServiceMock.RefillMoneyOnAccount(1000);
        userServiceMock.CheckAccountBalance();
        Assert.Null(userServiceMock.CheckAccountBalance());
    }
}