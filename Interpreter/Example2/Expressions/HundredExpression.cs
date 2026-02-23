namespace Interpreter.Example2.Expressions
{
    public class HundredExpression : Expression
    {
        public override int Interpret(Context context)
        {
            if (context.Input.StartsWith("CM"))
            {
                context.Output += 900;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("CD"))
            {
                context.Output += 400;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("D"))
            {
                context.Output += 500;
                context.Input = context.Input.Substring(1);

                // Handle remaining hundreds after D (e.g., DCC = 700)
                while (context.Input.StartsWith("C"))
                {
                    context.Output += 100;
                    context.Input = context.Input.Substring(1);
                }
            }
            else
            {
                // Handle C, CC, CCC
                while (context.Input.StartsWith("C"))
                {
                    context.Output += 100;
                    context.Input = context.Input.Substring(1);
                }
            }

            return context.Output;
        }
    }
}
