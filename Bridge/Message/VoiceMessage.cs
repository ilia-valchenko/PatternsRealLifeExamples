using System;

namespace Bridge.Message
{
    public class VoiceMessage : IMessage
    {
        public byte[] GetBytes()
        {
            throw new NotImplementedException();
        }
    }
}