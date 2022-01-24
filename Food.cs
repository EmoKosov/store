using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Food : Product 
    {
        public Food(decimal quantity, string name, string brand, decimal price, DateTime expirationDate) : base(quantity, name, brand, price)
        {
            this.expirationDate = expirationDate;
            if (expirationDate < DateTime.Now.AddDays(-5))
            {
                this.DiscountPercent = 10;
                DiscountSum = (Price * quantity) / DiscountPercent;
            }
            else 
            {
                this.Price = price * 0.5m;
                this.DiscountPercent = 50;
                DiscountSum = (Price * quantity) / DiscountPercent;
            }
        }
        private DateTime expirationDate;
        public DateTime ExpiratoinDate
        {
            get { return this.expirationDate; }
            set { this.expirationDate = value; }
        }
    }
}
