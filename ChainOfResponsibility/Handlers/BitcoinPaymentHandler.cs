using System;

namespace ChainOfResponsibility.Handlers
{
    public class BitcoinPaymentHandler : PaymentHandlerBase
    {
        private const decimal OperationLimit = 1000;

        public override void HandlePayment(decimal amount)
        {
            if (amount <= OperationLimit)
            {
                Console.WriteLine("Done. Bitcoin transaction was successfully completed.");
            }
            else
            {
                Console.WriteLine("Cannot pay using bitcoin. Proceeding...");
                this.nextHandler.HandlePayment(amount);
            }
        }
    }
}
