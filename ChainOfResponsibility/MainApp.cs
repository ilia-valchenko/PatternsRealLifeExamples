using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    public class MainApp
    {
        public static void Main()
        {
            var bankPaymentHandler = new BankPaymentHandler();
            var paypalPaymentHandler = new PaypalPaymentHandler();
            var bitcoinPaymentHandler = new BitcoinPaymentHandler();

            bankPaymentHandler.SetNextHandler(paypalPaymentHandler);
            paypalPaymentHandler.SetNextHandler(bitcoinPaymentHandler);

            decimal amount = 450;
            bankPaymentHandler.HandlePayment(amount);
        }
    }
}
