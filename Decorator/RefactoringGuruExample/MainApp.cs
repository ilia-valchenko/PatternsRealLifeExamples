using Decorator.RefactoringGuruExample.Message;
using Decorator.RefactoringGuruExample.Notificator;

namespace Decorator.RefactoringGuruExample
{
    public class MainApp
    {
        public void Main()
        {
            var message = new TextMessage("Hello World!");

            var emailNotificator = new EmailNotificator();
            INotificator decorator = new FacebookNotificatorDecorator(emailNotificator);
            decorator = new SlackNotificatorDecorator(decorator);

            decorator.Send(message);
        }
    }
}