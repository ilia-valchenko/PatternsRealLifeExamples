using System;
using System.Collections.Generic;
using Observer.OrderProcessingSystem.Observers.Interfaces;
using Observer.OrderProcessingSystem.Subject.Interfaces;

namespace Observer.OrderProcessingSystem.Subject
{
    public class Order : IOrderSubject
    {
        private readonly List<IOrderObserver> _observers = new List<IOrderObserver>();
        private readonly string _orderId;
        private readonly decimal _totalAmount;
        private readonly string _customerEmail;

        public string OrderId => _orderId;
        public decimal TotalAmount => _totalAmount;
        public string CustomerEmail => _customerEmail;

        public Order(string orderId, decimal totalAmount, string customerEmail)
        {
            _orderId = orderId;
            _totalAmount = totalAmount;
            _customerEmail = customerEmail;
        }

        /// <inheritdoc/>
        public void Attach(IOrderObserver observer) => _observers.Add(observer);

        /// <inheritdoc/>
        public void Detach(IOrderObserver observer) => _observers.Remove(observer);

        /// <inheritdoc/>
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void PlaceOrder()
        {
            Console.WriteLine($"Order '{_orderId}' placed. Total amount: {_totalAmount:C}");

            // Perform core order logic (save to DB, etc.)
            // Then notify all observers

            Notify();
        }
    }
}
