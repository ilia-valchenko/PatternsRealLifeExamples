using Bridge.Message;
using Bridge.MessageSender;

namespace Bridge
{
    public class MainApp
    {
        public void Main()
        {
            // Example 1
            AbstractMessage shortMessage = new ShortMessage(new TextMessageSender());
            shortMessage.SendMessage(new TextMessage("Hello World!"));

            // Example 2
            AbstractMessage message = new DefaultMessage(new VoiceMessageSender());
            message.SendMessage(new VoiceMessage());
        }
    }
}