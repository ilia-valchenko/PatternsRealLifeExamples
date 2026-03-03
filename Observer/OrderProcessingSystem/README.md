# Order processing system
Another classic software-world example of the Observer pattern is an order processing system in an e-commerce platform. When a customer places an order, multiple subsystems need to react:
- **Inventory** updates stock levels.
- **Shipping** schedules delivery.
- **Billing** charges the customer.
- **Notifications** send an email/SMS to the customer.
- **Analytics** logs the order for reporting.

Instead of hardcoding all these dependencies inside the order placement logic, we can make the Order the subject and each subsystem an observer. This keeps the order placement code decoupled and easily extensible (e.g., adding a fraud detection service later without touching existing code).
