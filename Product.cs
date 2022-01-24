using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Product 
    {
        public int DiscountPercent = 0;
        public decimal DiscountSum = 0;
        public Product(decimal quantity, string name, string brand, decimal price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.quantity = quantity;
        }
        private decimal quantity;
        private string name;
        private string brand;
        private decimal price;
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Name 
        {
            get { return name; }   
            set { name = value; }  
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
