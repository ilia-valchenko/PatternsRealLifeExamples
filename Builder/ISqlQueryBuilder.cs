﻿using System.Collections.Generic;

namespace Builder
{
    // You can use the Builder when you want to avoid a huge constructor
    // that has a lot of parameters.
    public interface ISqlQueryBuilder
    {
        void BuildSelect(string tableName, IList<string> columns);

        void BuildWhere(string columnName, string value, Operation operation);

        void BuildLimit(int start, int offset);

        // The GetResult method can return an interface or an abstract class
        // if the products have the same interface.
        string GetResult();
    }
}