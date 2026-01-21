using Command.Example2.Interfaces;

namespace Command.Example2.Commands
{
    public class TurnOnCommand : ICommand
    {
        private readonly IDevice _device;

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnOnCommand"/> class.
        /// </summary>
        public TurnOnCommand(IDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOn();
        }
    }
}
