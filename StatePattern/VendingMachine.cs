using DesignPatterns.StatePattern.Models;
using DesignPatterns.StatePattern.States;

namespace DesignPatterns.StatePattern
{
    internal class VendingMachine
    {
        private readonly List<Product> _products;
        private readonly List<Transaction> _transactions;
        private State _currentState;
        private double _totalAmount = 0;
        private Product? _selectedProduct;
        public Product? SelectedProduct
        {
            get => _selectedProduct;
            set => _selectedProduct = value;
        }

        public double TotalAmount
        {
            get => _totalAmount;
            set => _totalAmount = value;
        }

        public VendingMachine()
        {
            _products = new List<Product>();
            _transactions = new List<Transaction>();
            _currentState = new IdleState(this);
        }

        public void SetState(State state)
        {
            _currentState = state;
        }

        public string GetState()
        {
            return _currentState.GetType().Name;
        }

        public void AddTransaction(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction), "Transaction cannot be null.");
            _transactions.Add(transaction);
        }

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            foreach (var existingProduct in _products)
            {
                if (existingProduct.Name == product.Name)
                {
                    existingProduct.InventoryLevel += product.InventoryLevel;
                    return;
                }
            }
            _products.Add(product);
        }

        public void DispenseOrRemoveProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            var existingProduct = _products.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct?.InventoryLevel > 0 && existingProduct != null)
                existingProduct.InventoryLevel--;
            else if (existingProduct != null)
                _products.Remove(existingProduct);
        }

        public bool IsProductAvailable(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Name == product.Name);
            return existingProduct != null && existingProduct.InventoryLevel > 0;
        }

        public void InsertMoney(double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero.");
            _currentState.InsertMoney(amount);
        }

        public void SelectProduct(Product product, double inputAmount)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            _currentState.SelectProduct(product, inputAmount);
        }

        public void DispenseProduct()
        {
            _currentState.DispenseProduct();
        }

        public void CancelTransaction()
        {
            _currentState.CancelTransaction();
        }

        public void Refund(double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero.");
            _currentState.Refund(amount);
        }

        public void RestockProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            _currentState.RestockProduct(product);
        }

        public void EnterServiceMode()
        {
            _currentState.EnterServiceMode();
        }

        public void ExitServiceMode()
        {
            _currentState.ExitServiceMode();
        }
    }
}
