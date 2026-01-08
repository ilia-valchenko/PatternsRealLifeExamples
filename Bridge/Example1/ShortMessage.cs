using System;
using Bridge.Example1.Message.Interfaces;
using Bridge.Example1.MessageSender.Interfaces;

namespace Bridge.Example1
{
    public class ShortMessage : AbstractMessage
    {
        // TODO: The value has to be read from a configuration file.
        private const int Limit = 1000;

        public ShortMessage(IMessageSender sender) : base(sender)
        {
        }

        public override void SendMessage(IMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            var bytes = message.GetBytes();

            if (bytes.Length == 0)
            {
                return;
            }

            if (bytes.Length > Limit)
            {
                throw new ArgumentException("The message is too long.");
            }

            Sender.SendMessage(message);
        }
    }
}