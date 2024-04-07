using System;

class Product
    {
        public string Name { get; }
        public int ProductId { get; }
        public double PricePerUnit { get; }
        public int Quantity { get; }

        public Product(string name, int productId, double pricePerUnit, int quantity)
        {
            Name = name;
            ProductId = productId;
            PricePerUnit = pricePerUnit;
            Quantity = quantity;
        }

        public double GetTotalCost()
        {
            return PricePerUnit * Quantity;
        }
    }