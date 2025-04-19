using DesignPatterns.StatePattern.Models;

namespace DesignPatterns.StatePattern.States
{
    internal class ServiceModeState : State
    {
        public ServiceModeState(VendingMachine vendingMachine) : base(vendingMachine)
        {
            Console.WriteLine("[Current State] SERVICEMODE");
        }

        public override void RestockProduct(Product product)
        {
            _vendingMachine.AddProduct(product);
            Console.WriteLine($"Product {product.Name} restocked.");
            return;
        }

        public override void ExitServiceMode()
        {
            Console.WriteLine("Exiting service mode...");
            Console.WriteLine("Service mode deactivated.");
            _vendingMachine.SetState(new IdleState(_vendingMachine));
            return;
        }
    }
}
