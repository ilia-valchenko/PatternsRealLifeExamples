using System;
using Bridge.Example1.Message.Interfaces;
using Bridge.Example1.MessageSender.Interfaces;

namespace Bridge.Example1
{
    // The Bridge pattern is based on composition.
    // The Bridge divides a program by two layers: abstraction (like warm and round, cold and square) and realization.
    // The abstraction will contain (composition) an interface that will be implemented by one of concrete implementations.
    // The abstraction delegates all the  work to the a realization.
    // The abstraction and the realization interfaces can be different.
    // A client interacts only with the abstraction.
    // It allows us to modify the abstraction and the realization independently.

    // P.S. The abstraction can be modified by using an inheritance.
    // In this case the client will chose an appropriate realization of the abstraction.

    // Examples:
    // * UI - API
    // * UI - cross-platform framework (we can change the UI without modifying the framework)
    public abstract class AbstractMessage
    {
        private IMessageSender _sender;

        protected IMessageSender Sender
        {
            get
            {
                return _sender;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(_sender));
                }

                _sender = value;
            }
        }

        protected AbstractMessage(IMessageSender sender)
        {
            Sender = sender;
        }

        public abstract void SendMessage(IMessage message);
    }
}