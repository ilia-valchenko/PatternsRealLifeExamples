using System;
using System.Data;

namespace FactoryMethod.Common.Sql
{
    public class SecurityHelper : Helper
    {
        public override Helper CreateHelper(int partnerId)
        {
            throw new NotImplementedException();
        }

        public override IDataReader ExecuteAsDataReader()
        {
            throw new NotImplementedException();
        }

        public override DataTable ExecuteAsDataTable()
        {
            throw new NotImplementedException();
        }

        public override T ExecuteAsScalar<T>()
        {
            throw new NotImplementedException();
        }
    }
}