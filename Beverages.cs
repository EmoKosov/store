using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Beverages : Product 
    {
        public Beverages(decimal quantity, string name, string brand, decimal price, DateTime expirationDate)
            : base(quantity, name, brand, price)
        {
            this.expirationDate = expirationDate;
            if (expirationDate < DateTime.Now.AddDays(-5))
            {
                this.DiscountPercent = 10;
                DiscountSum = Price / DiscountPercent;
            }
            else
            {
                this.DiscountPercent = 50;
                DiscountSum = Price / DiscountPercent;
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
