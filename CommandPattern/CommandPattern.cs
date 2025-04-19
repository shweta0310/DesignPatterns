namespace DesignPatterns.CommandPattern
{
    internal class CommandPattern
    {
        internal static void RunPattern()
        {
            Account account = new Account(1000);
            List<ICommand> commands = new List<ICommand>
            {
                new DepositCommand(account, 200),
                new DepositCommand(account, 300),
                new CheckBalanceCommand(account),
                new DepositCommand(account, 500),
                new CheckBalanceCommand(account),
                new WithdrawCommand(account, 3000),
                new CheckBalanceCommand(account),
                new WithdrawCommand(account, 1000),
                new CheckBalanceCommand(account),
            };
            Account.ProcessAccountCommands(commands);
        }
    }
}
