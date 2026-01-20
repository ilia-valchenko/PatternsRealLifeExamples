using System;

namespace Command.Example1
{
    public class CanvasReceiver
    {
        public void DrawCircle()
        {
            Console.WriteLine("I'm drawing a circle.");
        }

        public void RemoveCircle()
        {
            Console.WriteLine("I'm removing a circle.");
        }

        public void DrawRectangle()
        {
            Console.WriteLine("I'm drawing a rectangle.");
        }

        public void RemoveRectangle()
        {
            Console.WriteLine("I'm removing a rectangle.");
        }
    }
}
