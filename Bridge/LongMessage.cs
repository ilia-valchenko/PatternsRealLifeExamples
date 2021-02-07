using System;
using Bridge.Message;
using Bridge.MessageSender;

namespace Bridge
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

            this.Sender.SendMessage(message);
        }
    }
}