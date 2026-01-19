using System;

namespace ChainOfResponsibility.Handlers
{
    public class BankPaymentHandler : PaymentHandlerBase
    {
        private const decimal OperationLimit = 100;

        public override void HandlePayment(decimal amount)
        {
            if (amount <= OperationLimit)
            {
                Console.WriteLine("Done. Bank transaction was successfully completed.");
            }
            else
            {
                 this.nextHandler.HandlePayment(amount);
            }
        }
    }
}
