using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace Lab5.Infastructure.DataAccess.Migrations;

[Migration(1, "Initial")]
public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
    """
    create table users
    (
        user_id bigint primary key generated always as identity ,
        user_name text not null ,
        user_account bigint not null generated always as identity ,
        user_password text not null ,
        user_balance numeric not null
    );

    create table operation_detail
    (
        transaction_number bigint primary key generated always as identity ,
        user_account bigint  ,
        operation_cash_amount numeric not null
        
    );
    """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
    """
    drop table users;
    drop table operation_detail;

    """;
}