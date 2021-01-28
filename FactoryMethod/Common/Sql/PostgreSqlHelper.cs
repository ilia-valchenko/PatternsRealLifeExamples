using System.Data;
using Npgsql;

namespace FactoryMethod.Common.Sql
{
    public class PostgreSqlHelper : Helper
    {
        public override IDbConnection CreateDatabaseConnection()
        {
            return new NpgsqlConnection();
        }
    }
}