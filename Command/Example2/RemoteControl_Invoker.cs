using System;
using Command.Example2.Interfaces;

namespace Command.Example2
{
    // Invoker
    public class RemoteControl_Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
