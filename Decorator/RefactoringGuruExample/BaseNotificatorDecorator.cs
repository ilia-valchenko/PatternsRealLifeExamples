using Decorator.RefactoringGuruExample.Message;

namespace Decorator.RefactoringGuruExample
{
    // Sometimes the Decorator is called Wrapper.
    // It implements the same repository as wrapee implements, but
    // the decorator inself provides an extended interface.
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