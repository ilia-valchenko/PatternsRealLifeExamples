using System.Data;
using System.Data.SqlClient;

namespace FactoryMethod.Common.Sql
{
    public class MsSqlHelper : DatabaseHelper
    {
        public override IDbConnection CreateDatabaseConnection()
        {
            return new SqlConnection();
        }
    }
}