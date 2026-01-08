using Bridge.Example1.Message;
using Bridge.Example1.MessageSender;

namespace Bridge.Example1
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