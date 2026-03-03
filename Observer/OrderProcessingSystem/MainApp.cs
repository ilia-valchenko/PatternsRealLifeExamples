using Observer.OrderProcessingSystem.Observers;
using Observer.OrderProcessingSystem.Observers.Interfaces;
using Observer.OrderProcessingSystem.Subject;

namespace Observer.OrderProcessingSystem
{
    public static class MainApp
    {
        // NOTE: The Observer pattern lets one object (the subject) notify
        // a list of other objects (the observers) automatically when its state changes,
        // without them being tightly coupled. Think of it as a subscription system:
        // observers sign up to receive updates from the subject.
        public static void Main()
        {
            // Create order
            var order = new Order("ORD-12345", 299.99m, "customer@example.com");

            // Create observers
            IOrderObserver inventory = new InventoryService();
            IOrderObserver shipping = new ShippingService();
            IOrderObserver billing = new BillingService();
            IOrderObserver notifications = new NotificationService();
            IOrderObserver analytics = new AnalyticsService();

            // Attach observers to the order
            order.Attach(inventory);
            order.Attach(shipping);
            order.Attach(billing);
            order.Attach(notifications);
            order.Attach(analytics);

            // Place the order – this triggers notifications
            order.PlaceOrder();

            // Output:
            // Order ORD-12345 placed. Total: $299.99
            // Inventory: Reserved stock for order ORD-12345
            // Shipping: Scheduled delivery for order ORD-12345
            // Billing: Charged $299.99 to customer customer@example.com
            // Notification: Sent confirmation email to customer@example.com
            // Analytics: Logged order ORD-12345 for reporting
        }
    }
}
