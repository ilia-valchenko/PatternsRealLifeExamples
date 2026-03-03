using System;
using Observer.OrderProcessingSystem.Observers.Interfaces;
using Observer.OrderProcessingSystem.Subject;

namespace Observer.OrderProcessingSystem.Observers
{
    public class AnalyticsService : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"Analytics: Logged order '{order.OrderId}' for reporting.");
            // Logic to send data to analytics system
        }
    }
}
