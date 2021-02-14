using Decorator.RefactoringGuruExample.Message;

namespace Decorator.RefactoringGuruExample
{
    public class SlackNotificatorDecorator : BaseNotificatorDecorator
    {
        private readonly INotificator notificator;

        public SlackNotificatorDecorator(INotificator notificator) : base(notificator)
        {
            this.notificator = notificator;
        }

        public override void Send(IMessage message)
        {
            // TODO: Send slack notification.

            this.notificator.Send(message);
        }
    }
}