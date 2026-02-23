namespace Interpreter.Example2.Expressions
{
    public class TenExpression : Expression
    {
        public override int Interpret(Context context)
        {
            if (context.Input.StartsWith("XC"))
            {
                context.Output += 90;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("XL"))
            {
                context.Output += 40;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("L"))
            {
                context.Output += 50;
                context.Input = context.Input.Substring(1);

                // Handle remaining tens after L (e.g., LXX = 70)
                while (context.Input.StartsWith("X"))
                {
                    context.Output += 10;
                    context.Input = context.Input.Substring(1);
                }
            }
            else
            {
                // Handle X, XX, XXX
                while (context.Input.StartsWith("X"))
                {
                    context.Output += 10;
                    context.Input = context.Input.Substring(1);
                }
            }

            return context.Output;
        }
    }
}
