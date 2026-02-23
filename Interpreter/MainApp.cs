using System;
using Interpreter.Expressions;
using Interpreter.Interfaces;

namespace Interpreter
{
    public class MainApp
    {
        public static void Main()
        {
            // Expression: (5 + 3) * 2
            IExpression five = new NumberExpression(5);
            IExpression three = new NumberExpression(3);
            IExpression two = new NumberExpression(2);

            IExpression addition = new AddExpression(five , three);
            IExpression multiplication = new MultiplyExpression(addition, two);

            int result = multiplication.Interpret();
            Console.WriteLine($"(5 + 3) * 2 = {result}"); // (5 + 3) * 2 = 16
        }
    }
}
