using DesignPatterns.StatePattern.Models;

namespace DesignPatterns.StatePattern.States
{
    internal class ProductSelectedState : State
    {
        public ProductSelectedState(VendingMachine vendingMachine) : base(vendingMachine)
        {
            Console.WriteLine("[Current State] PRODUCTSELECTED");
        }

        public override void DispenseProduct()
        {
            _vendingMachine.SetState(new DispensingState(_vendingMachine));
            return;
        }

        public override void CancelTransaction()
        {
            Console.WriteLine("Transaction cancelled. Returning to idle state.");
            _vendingMachine.SetState(new IdleState(_vendingMachine));
            return;
        }
    }
}
