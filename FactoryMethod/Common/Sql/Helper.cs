using System.Data;

namespace FactoryMethod.Common.Sql
{
    public abstract class Helper
    {
        public string Query { get; set; }

        // The factory method.
        // It allow us to work with different types of objects by using a single interface.
        public abstract IDbConnection CreateDatabaseConnection();

        public IDataReader ExecuteAsDataReader()
        {
            using (var connection = this.CreateDatabaseConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = this.Query;
                    return command.ExecuteReader();
                }
            }
        }
    }
}