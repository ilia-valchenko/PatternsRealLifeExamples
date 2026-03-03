using System;
using Observer.OrderProcessingSystem.Observers.Interfaces;
using Observer.OrderProcessingSystem.Subject;

namespace Observer.OrderProcessingSystem.Observers
{
    public class NotificationService : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"Notification: Sent confirmation email to {order.CustomerEmail}.");
            // Logic to send email
        }
    }
}
