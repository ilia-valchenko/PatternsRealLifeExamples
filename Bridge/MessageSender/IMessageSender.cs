using Bridge.Message;

namespace Bridge.MessageSender
{
    public interface IMessageSender
    {
        void SendMessage(IMessage message);
    }
}