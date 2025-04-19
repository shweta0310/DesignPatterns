namespace DesignPatterns.FacadePattern
{
    internal class AccountService
    {
        public void AccountDetails(string accountId)
        {
            Console.WriteLine($"Account details displayed for account {accountId}");
        }
    }

    internal class TransferService
    {
        public void TransferFunds(string fromAccount, string toAccount, double amount)
        {
            Console.WriteLine($"Transferred {amount} from account {fromAccount} to account {toAccount}");
        }
    }

    internal class PaymentService
    {
        private readonly string _paymentGateway;
        public PaymentService(string paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }
        public void MakePayment(string fromAccount, string toAccount, double amount)
        {
            Console.WriteLine($"Payment of {amount} made from account {fromAccount} to account {toAccount} using {_paymentGateway}");
        }
    }
}
