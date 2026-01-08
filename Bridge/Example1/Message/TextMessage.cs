using System.Text;
using Bridge.Example1.Message.Interfaces;

namespace Bridge.Example1.Message
{
    public class TextMessage : IMessage
    {
        private readonly string _text;

        public TextMessage()
        {
            _text = string.Empty;
        }

        public TextMessage(string text)
        {
            _text = text;
        }

        public byte[] GetBytes()
        {
            return Encoding.UTF8.GetBytes(_text);
        }
    }
}