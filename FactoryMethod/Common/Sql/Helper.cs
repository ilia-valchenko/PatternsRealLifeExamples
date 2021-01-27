using System.Data;

namespace FactoryMethod.Common.Sql
{
    public abstract class Helper
    {
        public string Query { get; set; }

        public abstract Helper CreateHelper(int partnerId);

        public abstract T ExecuteAsScalar<T>() where T : struct;

        public abstract DataTable ExecuteAsDataTable();

        public abstract IDataReader ExecuteAsDataReader();
    }
}