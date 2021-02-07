﻿using System;
using Bridge.Message;
using Bridge.MessageSender;

namespace Bridge
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
        private IMessageSender sender;

        protected IMessageSender Sender
        {
            get
            {
                return this.sender;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(this.sender));
                }

                this.sender = value;
            }
        }

        public AbstractMessage(IMessageSender sender)
        {
            this.Sender = sender;
        }

        public abstract void SendMessage(IMessage message);
    }
}