using Command.Example2.Commands;
using Command.Example2.Commands.TvCommands;
using Command.Example2.Devices;
using Command.Example2.Interfaces;

namespace Command.Example2
{
    // Note: The idea is to decouple the sender from the receiver.
    // It allows requests to be queued, logged, parameterized, or undone/redone.
    public class MainApp
    {
        public void Main()
        {
            // Create receivers
            TvDevice_Receiver tvDevice = new TvDevice_Receiver();

            // Create commands
            ICommand turnOnCommand = new TurnOnCommand(tvDevice);
            ICommand changeTvChannelCommand = new ChangeTvChannelCommand(tvDevice);

            // Create an invoker
            RemoteControl_Invoker remoteControl = new RemoteControl_Invoker();

            // Set and execute commands
            remoteControl.SetCommand(turnOnCommand);
            remoteControl.PressButton();

            remoteControl.SetCommand(changeTvChannelCommand);
            remoteControl.PressButton();
        }
    }
}
