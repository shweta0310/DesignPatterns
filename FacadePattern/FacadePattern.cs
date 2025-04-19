namespace DesignPatterns.FacadePattern
{
    internal class FacadePattern
    {
        public static void RunPattern()
        {
            PaymentService paymentService = new PaymentService("PayPal");
            BankingSystem bankingSystem = new BankingSystem(paymentService);
            bankingSystem.DisplayAccountDetails("12345");
            bankingSystem.TransferFunds("12345", "67890", 1000);
            bankingSystem.MakePayment("12345", "67890", 500, "12345");
        }
    }
}
