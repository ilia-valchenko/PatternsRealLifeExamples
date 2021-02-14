using System.Text;

namespace Decorator.RefactoringGuruExample.Message
{
    public class TextMessage : IMessage
    {
        private readonly string text;

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