using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Product> list = new List<Product>();
            Product food = new Food(2.45m,"apples", "brandA", 1.50m, new DateTime(2021, 6, 15));
            Product beverage = new Beverages(3,"Milk", "BrandM", 0.99m, new DateTime(2022, 2, 2));
            Product clothe = new Clothes(2,"T-shirt", "BrandT", 15.99m, "M", "violet");
            Product appliance = new Appliances(1,"laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 3, 3), 1.125m);

            list.Add(food);
            list.Add(beverage);
            list.Add(clothe);
            list.Add(appliance);

            Cashier.Print(list);
        }
    }
}
