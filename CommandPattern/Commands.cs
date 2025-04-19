namespace DesignPatterns.CommandPattern
{
    // Command interface
    internal interface ICommand
    {
        public void Execute();
        public void Undo();
    }

    // Concrete command classes
    internal class DepositCommand : ICommand
    {
        private Account Account { get; }
        private double Amount { get; }
        public DepositCommand(Account account, double amount)
        {
            Account = account;
            Amount = amount;
        }

        public void Execute()
        {
            Account.Deposit(Amount);
        }

        public void Undo()
        {
            Account.Withdraw(Amount);
        }
    }

    internal class WithdrawCommand : ICommand
    {
        private Account Account { get; }
        private double Amount { get; }
        public WithdrawCommand(Account account, double amount)
        {
            Account = account;
            Amount = amount;
        }

        public void Execute()
        {
            Account.Withdraw(Amount);
        }

        public void Undo()
        {
            Account.Deposit(Amount);
        }
    }

    internal class CheckBalanceCommand : ICommand
    {
        private Account Account { get; }
        public CheckBalanceCommand(Account account)
        {
            Account = account;
        }

        public void Execute()
        {
            Account.CheckBalance();
        }

        public void Undo()
        {
            Account.CheckBalance();
        }
    }
}
