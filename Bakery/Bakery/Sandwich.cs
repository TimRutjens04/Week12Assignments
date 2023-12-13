using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace Bakery
{
    [DataContract]
    public class Sandwich
    {
        [DataMember]
        public List<Ingredient> ingredients { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public double basePrice { get; set; }
        [DataMember]
        public BreadType bread {  get; set; }
        public Sandwich() { }
        public Sandwich(string name, double basePrice, BreadType bread, List<Ingredient> ingredients) 
        {
           this.name = name;
           this.basePrice = basePrice;
           this.bread = bread;
           this.ingredients = ingredients;
        }
        public string GetName()
        { return this.name; }

        public BreadType GetBread()
        { return this.bread; }
        public void SetPrice(double price)
        { basePrice = price; }
        public List<Ingredient> GetIngredients() 
        { return this.ingredients;}
        public void AddIngredient(List<Ingredient> ingredients, Ingredient ingredient)
        {
            if (ingredients.Count <= 5)
            {
                ingredients.Add(ingredient);
            }
            else { MessageBox.Show("You can have a maximum of 5 toppings."); }
        }

        public string GetInfo(string name, BreadType bread, Ingredient ingredient) 
        {

            return $"Name: {this.name} - Bread: {this.bread} with {ingredient}"; //ingredient should prob be list
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = basePrice;
            foreach (var ingredient in ingredients)
            {
                totalPrice += ingredient.Price;
            }
            return totalPrice;
        }

        public string DisplayInfoSandwich()
        {
            string breadValue = bread.ToString().Trim();
            string nameValue = name.Trim();
            string totalPriceValue = CalculateTotalPrice().ToString("C").Trim(); 

            string displayInfo = $"{breadValue} - {nameValue} - {totalPriceValue}";
            
            Debug.WriteLine($"Bread: {breadValue}");
            Debug.WriteLine($"Name: {nameValue}");
            Debug.WriteLine($"Base Price: {totalPriceValue}");
            Debug.WriteLine($"Display Info: {displayInfo}");

            return displayInfo;
        }

    }
}
