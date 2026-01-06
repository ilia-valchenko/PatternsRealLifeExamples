using System.Data;
using Npgsql;

namespace FactoryMethod.Common.Sql
{
    public class PostgreSqlHelper : DatabaseHelper
    {
        public override IDbConnection CreateDatabaseConnection()
        {
            return new NpgsqlConnection();
        }
    }
}