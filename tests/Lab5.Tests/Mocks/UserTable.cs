namespace Workshop5.Application.Users;

public class UserTable
{
    public UserTable(string name, string password, decimal balance)
    {
        Name = name;
        Password = password;
        Balance = balance;
    }

    public string Name { get; }
    public string Password { get; }
    public decimal Balance { get; private set; }

    public void ChangeBalance(decimal value)
    {
        Balance += value;
    }
}