using Itmo.Dev.Platform.Postgres.Connection;
using Lab5.Application.Abstraction.Repositories;
using Lab5.Application.Models.OperationsDetail;
using Npgsql;

namespace Lab5.Infastructure.DataAccess.Repositories;

public class OperationDetailRepository : IOperationDetailRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public OperationDetailRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public void UpdateOperationInformation(long? id, decimal value)
    {
        const string sql = """
                INSERT INTO operation_detail (user_account, operation_cash_amount)
                VALUES (@user_account, @operation_cash_amount);
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
        if (id != null) command.Parameters.AddWithValue("user_account", id);
        command.Parameters.AddWithValue("operation_cash_amount", value);
        command.ExecuteNonQuery();
    }

    public IEnumerable<OperationDetail> GetAllOperation()
    {
        const string sql = """
        select user_account, operation_cash_amount
        from operation_detail
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
        using NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            yield return new OperationDetail(
                reader.GetInt64(0),
                reader.GetDecimal(1));
        }
    }
}