using System;
using System.Collections.Generic;
using Builder.Enums;
using Builder.Interfaces;

namespace Builder
{
    public class PostgreSqlQueryBuilder : IQueryBuilder
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