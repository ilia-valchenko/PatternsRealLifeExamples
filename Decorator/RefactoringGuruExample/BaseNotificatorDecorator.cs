using Decorator.RefactoringGuruExample.Message;

namespace Decorator.RefactoringGuruExample
{
    // Sometimes the Decorator is called Wrapper.
    // It has the same interface as wrapee has.
    public abstract class BaseNotificatorDecorator : INotificator
    {
        protected readonly INotificator wrapee;

        public BaseNotificatorDecorator(INotificator wrapee)
        {
            this.wrapee = wrapee;
        }

        public abstract void Send(IMessage message);
    }
}