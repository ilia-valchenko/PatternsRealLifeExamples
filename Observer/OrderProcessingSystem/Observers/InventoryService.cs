using System;
using Observer.OrderProcessingSystem.Observers.Interfaces;
using Observer.OrderProcessingSystem.Subject;

namespace Observer.OrderProcessingSystem.Observers
{
    public class InventoryService : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"Inventory: Reserved stock for order '{order.OrderId}'.");
            // Logic to decrement stock levels
        }
    }
}
