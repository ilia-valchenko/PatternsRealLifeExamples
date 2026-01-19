namespace ChainOfResponsibility
{
    public abstract class PaymentHandlerBase
    {
        protected PaymentHandlerBase nextHandler;

        public void SetNextHandler(PaymentHandlerBase nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract void HandlePayment(decimal amount);
    }
}
