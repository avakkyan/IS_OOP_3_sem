using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstraction.Repositories;
using Lab5.Application.Models.OperationsDetail;
using Lab5.Application.Models.Users;
using Npgsql;

namespace Lab5.Infastructure.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public UserRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public User? FindUserByUsernameAndPassword(int userId, string password)
    {
        const string sql = """
        select user_id, user_name, user_account, user_password, user_balance
        from users
        where user_id = @user_id and user_password = @user_password
        """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", userId);
        command.AddParameter("user_password", password);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new User(
            Id: reader.GetInt64(0),
            Username: reader.GetString(1),
            Account: reader.GetInt64(2),
            Password: reader.GetString(3),
            Balance: reader.GetInt64(4));
    }

    public long? CheckAccountBalance(long? userId)
    {
        const string sql = """
        select user_balance
        from users
        where user_id = @user_id
        """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_id", userId);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return reader.GetInt64(0);
    }

    public void CreateBankAccount(string name, string password)
    {
        const string sql = """
        insert into users (user_name, user_password, user_balance)
        values (@user_name, @user_password, @user_balance)
        """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("user_name", name);
        command.AddParameter("user_password", password);
        command.AddParameter("user_balance", 0);

        command.ExecuteNonQuery();
    }

    public WithdrawMoneyResult WithdrawMoneyFromAccount(long? password, decimal amount)
    {
        const string sql = """
        update users
        set user_balance = user_balance - @amount 
        where user_id = @user_id and user_balance >= @amount
        """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("password", password);
        command.AddParameter("amount", amount);

        command.ExecuteNonQuery();

        if (command.ExecuteNonQuery() != 1)
            return WithdrawMoneyResult.NotEnoughMoney;

        return WithdrawMoneyResult.Success;
    }

    public RefillMoneyResult RefillMoneyOnAccount(decimal amount)
    {
        const string sql = """
        update users
        set user_balance = user_balance + @amount 
        where user_id = @user_id
        """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("amount", amount);

        command.ExecuteNonQuery();

        if (command.ExecuteNonQuery() != 1)
            return RefillMoneyResult.NotSuccess;
        return RefillMoneyResult.Success;
    }
}