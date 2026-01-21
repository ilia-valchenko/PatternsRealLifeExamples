using System;
using Command.Example2.Interfaces;

namespace Command.Example2.Devices
{
    // Receiver
    public class TvDevice_Receiver : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Your TV is on now.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Your TV is OFF now.");
        }

        public void ChangeChannel()
        {
            Console.WriteLine("TV channel was changed.");
        }
    }
}
