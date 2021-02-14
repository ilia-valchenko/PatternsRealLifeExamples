using Decorator.RefactoringGuruExample.Message;

namespace Decorator.RefactoringGuruExample.Notificator
{
    public class EmailNotificator : INotificator
    {
        public void Send(IMessage message)
        {
            // TODO: Send email notification.
        }
    }
}