using Command.Example2.Interfaces;

namespace Command.Example2.Commands
{
    public class TurnOffCommand : ICommand
    {
        private readonly IDevice _device;

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnOffCommand"/> class.
        /// </summary>
        public TurnOffCommand(IDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOff();
        }
    }
}
