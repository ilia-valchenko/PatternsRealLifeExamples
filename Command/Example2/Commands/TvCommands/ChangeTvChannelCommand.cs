using Command.Example2.Devices;
using Command.Example2.Interfaces;

namespace Command.Example2.Commands.TvCommands
{
    public class ChangeTvChannelCommand : ICommand
    {
        private readonly TvDevice_Receiver _tvDevice;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeTvChannelCommand"/> class.
        /// </summary>
        public ChangeTvChannelCommand(TvDevice_Receiver tvDevice)
        {
            _tvDevice = tvDevice;
        }

        public void Execute()
        {
            _tvDevice.ChangeChannel();
        }
    }
}
