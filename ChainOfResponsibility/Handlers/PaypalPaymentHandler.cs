using System;

namespace ChainOfResponsibility.Handlers
{
    public class PaypalPaymentHandler : PaymentHandlerBase
    {
        private const decimal OperationLimit = 500;

        public override void HandlePayment(decimal amount)
        {
            if (amount <= OperationLimit)
            {
                Console.WriteLine("Done. Paypal transaction was successfully completed.");
            }
            else
            {
                Console.WriteLine("Cannot pay using paypal. Proceeding...");
                this.nextHandler.HandlePayment(amount);
            }
        }
    }
}
