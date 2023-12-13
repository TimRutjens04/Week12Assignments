using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bakery
{
    [DataContract]
    public class Ingredient
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }

        public Ingredient() { }
        public Ingredient(string name, double price) 
        {
            Name = name;
            Price = price;           
        }
        public string GetName()
        { return this.Name; }

        public double GetPrice()
        { return this.Price; }

        public string DisplayInfoIngredient() => $"{Name} - {Price:C}".Trim();
        
    }
}
