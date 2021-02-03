using System;
using System.Collections.Generic;

namespace Builder
{
    public class MySqlQueryBuilder : ISqlQueryBuilder
    {
        public void BuildLimit(int start, int offset)
        {
            throw new NotImplementedException();
        }

        public void BuildSelect(string tableName, IList<string> columns)
        {
            throw new NotImplementedException();
        }

        public void BuildWhere(string columnName, string value, Operation operation)
        {
            throw new NotImplementedException();
        }

        public string GetResult()
        {
            throw new NotImplementedException();
        }
    }
}