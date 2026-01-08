using System;
using Bridge.Example1.Message.Interfaces;
using Bridge.Example1.MessageSender.Interfaces;

namespace Bridge.Example1.MessageSender
{
    public class TextMessageSender : IMessageSender
    {
        public void SendMessage(IMessage message)
        {
            throw new NotImplementedException();
        }
    }
}