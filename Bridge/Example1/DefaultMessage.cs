using System;
using Bridge.Example1.Message.Interfaces;
using Bridge.Example1.MessageSender.Interfaces;

namespace Bridge.Example1
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

            Sender.SendMessage(message);
        }
    }
}