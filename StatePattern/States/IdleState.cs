using DesignPatterns.StatePattern.Models;

namespace DesignPatterns.StatePattern.States
{
    internal class IdleState : State
    {
        public IdleState(VendingMachine vendingMachine) : base(vendingMachine)
        {
            Console.WriteLine("[Current State] IDLE");
        }

        public override void InsertMoney(double amount)
        {
            Console.WriteLine($"Inserted {amount} dollars in the vending machine.");
            _vendingMachine.SetState(new HasMoneyState(_vendingMachine));
        }
    }
}
