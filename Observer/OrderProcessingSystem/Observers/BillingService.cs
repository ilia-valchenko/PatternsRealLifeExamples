using System;
using Observer.OrderProcessingSystem.Observers.Interfaces;
using Observer.OrderProcessingSystem.Subject;

namespace Observer.OrderProcessingSystem.Observers
{
    public class BillingService : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"Billing: Charged {order.TotalAmount:C} to customer {order.CustomerEmail}.");
            // Logic to process payment
        }
    }
}
