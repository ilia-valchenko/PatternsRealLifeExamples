using Decorator.RefactoringGuruExample.Message;

namespace Decorator.RefactoringGuruExample
{
    public class FacebookNotificatorDecorator : BaseNotificatorDecorator
    {
        private readonly INotificator notificator;

        public FacebookNotificatorDecorator(INotificator notificator) : base(notificator)
        {
            this.notificator = notificator;
        }

        public override void Send(IMessage message)
        {
            // TODO: Send facebook notification.

            this.notificator.Send(message);
        }
    }
}