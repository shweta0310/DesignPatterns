using DesignPatterns.StatePattern.Models;

namespace DesignPatterns.StatePattern.States
{
    internal class DispensingState : State
    {
        public DispensingState(VendingMachine vendingMachine) : base(vendingMachine)
        {
            Console.WriteLine("[Current State] DISPENSING");

            if (_vendingMachine.SelectedProduct != null)
            {
                _vendingMachine.DispenseOrRemoveProduct(_vendingMachine.SelectedProduct);
                Console.WriteLine($"Dispensing {_vendingMachine.SelectedProduct?.Name}...");
                Console.WriteLine($"Please take your {_vendingMachine.SelectedProduct?.Name}.");
                _vendingMachine.SelectedProduct = null;
                Transaction transaction = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    Product = _vendingMachine.SelectedProduct,
                    Date = DateTime.Now,
                };
                _vendingMachine.AddTransaction(transaction);
                _vendingMachine.SetState(new IdleState(_vendingMachine));
            }
        }
    }
}
