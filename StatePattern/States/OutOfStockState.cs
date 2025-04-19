using DesignPatterns.StatePattern.Models;

namespace DesignPatterns.StatePattern.States
{
    internal class OutOfStockState : State
    {
        public OutOfStockState(VendingMachine vendingMachine) : base(vendingMachine)
        {
            Console.WriteLine("[Current State] OUTOFSTOCK");
        }

        public override void RestockProduct(Product product)
        {
            _vendingMachine.AddProduct(product);
            Console.WriteLine($"Product {product.Name} restocked.");
            _vendingMachine.SetState(new IdleState(_vendingMachine));
        }

        public override void CancelTransaction()
        {
            Console.WriteLine("Transaction cancelled. Returning to idle state.");
            _vendingMachine.SetState(new IdleState(_vendingMachine));
            return;
        }
    }
}
