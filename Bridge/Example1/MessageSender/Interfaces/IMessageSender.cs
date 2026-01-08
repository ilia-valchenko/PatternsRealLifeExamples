using Bridge.Example1.Message.Interfaces;

namespace Bridge.Example1.MessageSender.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(IMessage message);
    }
}