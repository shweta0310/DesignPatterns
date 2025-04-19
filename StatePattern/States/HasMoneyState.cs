using DesignPatterns.StatePattern.Models;

namespace DesignPatterns.StatePattern.States
{
    internal class HasMoneyState : State
    {
        public HasMoneyState(VendingMachine vendingMachine) : base(vendingMachine)
        {
            Console.WriteLine("[Current State] HASMONEY");
        }

        public override void SelectProduct(Product product, double inputAmount)
        {
            if (product == null)
            {
                Console.WriteLine("Invalid product selection.");
                return;
            }
            else if (!_vendingMachine.IsProductAvailable(product))
            {
                Console.WriteLine($"Product {product.Name} is out of stock.");
                _vendingMachine.SetState(new OutOfStockState(_vendingMachine));
                return;
            }
            else if (inputAmount < product.Price)
            {
                Console.WriteLine($"Insufficient funds. Please insert more money.");
                return;
            }

            _vendingMachine.SelectedProduct = product;
            _vendingMachine.TotalAmount += product.Price;

            double refundAmount = inputAmount - product.Price;
            Refund(refundAmount);
            _vendingMachine.SetState(new ProductSelectedState(_vendingMachine));
            return;
        }

        public override void Refund(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Refunding {amount} dollars.");
            }
            else
            {
                Console.WriteLine("No money to refund.");
            }
        }

        public override void CancelTransaction()
        {
            Console.WriteLine("Transaction cancelled. Returning to idle state.");
            _vendingMachine.SetState(new IdleState(_vendingMachine));
            return;
        }
    }
}
