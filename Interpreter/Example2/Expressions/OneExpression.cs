namespace Interpreter.Example2.Expressions
{
    public class OneExpression : Expression
    {
        public override int Interpret(Context context)
        {
            if (context.Input.StartsWith("IX"))
            {
                context.Output += 9;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("IV"))
            {
                context.Output += 4;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("V"))
            {
                context.Output += 5;
                context.Input = context.Input.Substring(1);

                // Handle remaining ones after V (e.g., VII = 7)
                while (context.Input.StartsWith("I"))
                {
                    context.Output += 1;
                    context.Input = context.Input.Substring(1);
                }
            }
            else
            {
                // Handle I, II, III
                while (context.Input.StartsWith("I"))
                {
                    context.Output += 1;
                    context.Input = context.Input.Substring(1);
                }
            }

            return context.Output;
        }
    }
}
