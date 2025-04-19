namespace DesignPatterns.FacadePattern
{
    internal class BankingSystem
    {
        private readonly AccountService _accountService;
        private readonly TransferService _transferService;
        private readonly PaymentService _paymentService;
        public BankingSystem(PaymentService paymentService)
        {
            _accountService = new AccountService();
            _transferService = new TransferService();
            _paymentService = paymentService;
        }

        public void DisplayAccountDetails(string accountId)
        {
            _accountService.AccountDetails(accountId);
        }

        public void TransferFunds(string fromAccount, string toAccount, double amount)
        {
            _transferService.TransferFunds(fromAccount, toAccount, amount);
        }

        public void MakePayment(string fromAccount, string toAccount, double amount, string accountId)
        {
            _accountService.AccountDetails(accountId);
            _paymentService.MakePayment(fromAccount, toAccount, amount);
        }
    }
}
