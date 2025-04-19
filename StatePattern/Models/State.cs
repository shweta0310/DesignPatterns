using DesignPatterns.StatePattern.States;

namespace DesignPatterns.StatePattern.Models
{
    internal abstract class State
    {
        protected VendingMachine _vendingMachine;
        protected State(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void SetState(State state)
        {
            _vendingMachine.SetState(state);
        }

        public virtual void InsertMoney(double amount)
        {
            throw new InvalidOperationException($"{nameof(InsertMoney)} method is not valid in state {_vendingMachine.GetState()}.");
        }
        public virtual void SelectProduct(Product product, double inputAmount)
        {
            throw new InvalidOperationException($"{nameof(SelectProduct)} method is not valid in state {_vendingMachine.GetState()}.");
        }
        public virtual void DispenseProduct()
        {
            throw new InvalidOperationException($"{nameof(DispenseProduct)} method is not valid in state {_vendingMachine.GetState()}.");
        }
        public virtual void CancelTransaction()
        {
            throw new InvalidOperationException($"{nameof(CancelTransaction)} method is not valid in state {_vendingMachine.GetState()}.");
        }
        public virtual void Refund(double amount)
        {
            throw new InvalidOperationException($"{nameof(Refund)} method is not valid in state {_vendingMachine.GetState()}.");
        }
        public virtual void RestockProduct(Product product)
        {
            throw new InvalidOperationException($"{nameof(RestockProduct)} method is not valid in state {_vendingMachine.GetState()}.");
        }
        public virtual void ExitServiceMode()
        {
            throw new InvalidOperationException($"{nameof(ExitServiceMode)} method is not valid in state {_vendingMachine.GetState()}.");
        }
        public void EnterServiceMode()
        {
            Console.WriteLine("Entering service mode...");
            Console.WriteLine("Service mode activated.");
            _vendingMachine.SetState(new ServiceModeState(_vendingMachine));
        }
    }
}
