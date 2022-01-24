using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public static class Cashier
    { 
        public static void Print(List<Product> cart)
        {
            decimal sum = 0;
            decimal discSum = 0;
            Console.WriteLine($"Date: {DateTime.UtcNow}");
            Console.WriteLine("---Products---");
            foreach (var item in cart)
            {
                sum += item.Quantity * item.Price;
                Console.WriteLine($"{item.Name} - {item.Brand}");
                Console.WriteLine($"{item.Quantity} x ${item.Price} = ${(item.Quantity*item.Price):f2}");
                if (item.DiscountPercent > 0)
                {
                    discSum += item.DiscountSum;
                    Console.WriteLine($"#discount {item.DiscountPercent} ${item.DiscountSum:f2}");  
                }
                Console.WriteLine();
                     
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"SUBTOTAL: ${sum:f2}");
            Console.WriteLine($"DISCOUNT: -${discSum:f2}");
            Console.WriteLine($"TOTAL: ${(sum - discSum):f2}");

        }
    }
}
