using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Clothes : Product 
    {
        public Clothes(decimal quantity, string name, string brand, decimal price, string size, string color) : base(quantity, name, brand, price)
        {
            this.Size = size;
            this.Color = color;
            if ((DateTime.UtcNow.DayOfWeek == DayOfWeek.Saturday || DateTime.UtcNow.DayOfWeek == DayOfWeek.Sunday) && this.Price > 999)
            {
                this.DiscountPercent = 5;
                DiscountSum = (Price * quantity) / DiscountPercent;
            }
            else
            {
                this.DiscountPercent = 10;
                DiscountSum = (Price * quantity) / DiscountPercent;
            }
        }
        private string size;
        private string color;
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
