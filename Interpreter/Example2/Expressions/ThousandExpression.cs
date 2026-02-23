namespace Interpreter.Example2.Expressions
{
    public class ThousandExpression : Expression
    {
        public override int Interpret(Context context)
        {
            while (context.Input.StartsWith("M"))
            {
                context.Output += 1000;
                context.Input = context.Input.Substring(1);
            }

            return context.Output;
        }
    }
}
