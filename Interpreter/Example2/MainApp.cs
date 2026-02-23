using System;
using System.Collections.Generic;
using Interpreter.Example2.Expressions;

namespace Interpreter.Example2
{
    public static class MainApp
    {
        public static void Main()
        {
            var initialContextInput = "MMVIII";
            var context = new Context { Input = initialContextInput }; // 2018

            var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (var expression in tree)
            {
                expression.Interpret(context);
            }

            Console.WriteLine($"{context.Input} = {context.Output}");
        }
    }
}
