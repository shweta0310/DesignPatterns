namespace DesignPatterns.CommandPattern
{
    // Receiver object
    internal class Account
    {
        public double Balance { get; private set; }

        public Account(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"Withdrawal amount {amount:C} exceeds account balance {Balance:C}");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current balance: {Balance:C}");
        }

        // Invoker 

        public static void ProcessAccountCommands(List<ICommand> commands)
        {
            foreach (ICommand c in commands)
            {
                c.Execute();
            }
        }
    }
}
