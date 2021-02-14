using Decorator.RefactoringGuruExample.Message;

namespace Decorator.RefactoringGuruExample
{
    public interface INotificator
    {
        void Send(IMessage message);
    }
}