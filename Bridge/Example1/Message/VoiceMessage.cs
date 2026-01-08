using System;
using Bridge.Example1.Message.Interfaces;

namespace Bridge.Example1.Message
{
    public class VoiceMessage : IMessage
    {
        public byte[] GetBytes()
        {
            throw new NotImplementedException();
        }
    }
}