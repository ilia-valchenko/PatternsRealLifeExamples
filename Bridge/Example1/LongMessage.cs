using System;
using Bridge.Example1.Message.Interfaces;
using Bridge.Example1.MessageSender.Interfaces;

namespace Bridge.Example1
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender sender) : base(sender)
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

            Sender.SendMessage(message);
        }
    }
}