using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Appliances : Product
    { 
        public Appliances(decimal quantity, string name, string brand, decimal price, string model, DateTime productionDate, decimal weight) 
            : base(quantity,name, brand, price)
        {
            this.weight = weight;
            this.productionDate = productionDate;
            this.weight = weight;
        }
        private string model;
        private DateTime productionDate;
        private decimal weight;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public DateTime ProductionDate
        {
            get { return productionDate; }
            set { productionDate = value; }
        }
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
