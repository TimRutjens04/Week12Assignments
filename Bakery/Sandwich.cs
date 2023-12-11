using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class Sandwich
    {
        string name { get; set; }
        double basePrice { get; set; }
        BreadType bread;
        public Sandwich(string name, double basePrice, BreadType bread, Ingredient ingredient) 
        {
           this.name = name;
           this.basePrice = basePrice;
           this.bread = bread;
           this.AddIngredient(ingredient);
        }
        public string GetName()
        { return this.name; }

        public BreadType GetBread()
        { return this.bread; }

        public void AddIngredient(Ingredient i)
        {
            
            /*
            if (ingredients.Count <= 5)
                {
                this.ingredients.Add();
                }
            else {return ingredients}
            */
        }

        public string GetInfo(string name, BreadType bread, Ingredient ingredient) 
        {

            return name + bread + ingredient;
        }
        public double GetPrice(double price) 
        {

            return price;
        }
    }
}
