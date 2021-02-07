using System;
using Bridge.Message;
using Bridge.MessageSender;

namespace Bridge
{
    public class DefaultMessage : AbstractMessage
    {
        public DefaultMessage(IMessageSender sender) : base(sender)
        {
        }

        public override void SendMessage(IMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            this.Sender.SendMessage(message);
        }
    }
}