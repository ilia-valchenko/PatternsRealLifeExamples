using Interpreter.Example1.Interfaces;

namespace Interpreter.Example1.Expressions
{
    // Terminal Expression
    public class NumberExpression : IExpression
    {
        private readonly int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret() => _number;
    }
}
