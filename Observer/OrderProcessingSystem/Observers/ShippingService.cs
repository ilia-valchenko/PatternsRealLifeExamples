using System;
using Observer.OrderProcessingSystem.Observers.Interfaces;
using Observer.OrderProcessingSystem.Subject;

namespace Observer.OrderProcessingSystem.Observers
{
    public class ShippingService : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"Shipping: Scheduled delivery for order '{order.OrderId}'.");
            // Logic to create shipment record
        }
    }
}
