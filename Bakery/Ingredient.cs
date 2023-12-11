using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class Ingredient
    {
        private string name { get; set; }
        private double price { get; set; }

        public Ingredient(string name, double price) 
        {
            this.name = name;
            this.price = price;           
        }
        public string GetName()
        { return this.name; }

        public double GetPrice()
        { return this.price; }
    }
}
