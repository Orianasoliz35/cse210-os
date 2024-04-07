using System;

class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double totalCost = _products.Sum(product => product.GetTotalCost());
            double shippingCost = _customer != null && _customer.LivesInUSA() ? 5 : 35;
            return totalCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            return string.Join("\n", _products.Select(product => $"{product.Name} (ID: {product.ProductId})"));
        }

        public string GetShippingLabel()
        {
            return _customer != null ? _customer.Address.GetFullAddress() : "No Address Provided";
        }
    }
