using System.Text;

namespace Bridge.Message
{
    public class TextMessage : IMessage
    {
        private string text;

        public TextMessage()
        {
            this.text = string.Empty;
        }

        public TextMessage(string text)
        {
            this.text = text;
        }

        public byte[] GetBytes()
        {
            return Encoding.UTF8.GetBytes(this.text);
        }
    }
}