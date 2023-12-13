using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery
{
    [DataContract]
    public class Bakery
    {
        [DataMember]
        public string _name;
        [DataMember]
        private const int VAT_PERCENTAGE = 9;
        [DataMember]
        public List<Sandwich> sandwiches {  get; set; }
        [DataMember]
        public List<Ingredient> ingredients { get; set; }

        public Bakery() 
        {
            _name = "Company2";
        }
        public Bakery(string name, List<Sandwich> sandwich, List<Ingredient> ingredient)
        {
            _name = name;
            sandwiches = sandwich;
            ingredients = ingredient;
            ingredients.Add(new Ingredient("Cucumber", 0.15));
            ingredients.Add(new Ingredient("Tomato", 0.15));
            ingredients.Add(new Ingredient("Cheddar", 0.2));
            ingredients.Add(new Ingredient("Ham", 0.15));
            ingredients.Add(new Ingredient("Chorizo", 0.25));
            ingredients.Add(new Ingredient("Apple", 0.1));
            ingredients.Add(new Ingredient("Tuna", 0.2));
            ingredients.Add(new Ingredient("Smoked Salmon", 0.4));
            ingredients.Add(new Ingredient("Cream cheese", 0.15));
            ingredients.Add(new Ingredient("Gouda cheese", 0.1));
            ingredients.Add(new Ingredient("Boiled eggs", 0.1));
        }

        public string GetName() 
            { return _name; }
            
        public List<Ingredient> GetAvailableIngredients() 
            { return ingredients; }

        public void AddSandwich(Sandwich sandwich) 
            {
            sandwiches.Add(sandwich);
            }

        public List<Sandwich> GetAvailableSandwiches(BreadType bread)
        {
            List<Sandwich> availableSandwiches = sandwiches
                .Where(s => s.GetBread() == bread)
                .ToList();

            return availableSandwiches;
        }

        public string GetAvailableSandwiches(string userInput) 
        {
            if (Enum.TryParse<BreadType>(userInput, out var selectedBreadType)) 
            {
                    string availableSandwiches = GetAvailableSandwiches(selectedBreadType).ToString();
                    return availableSandwiches;
            }
            else 
            { 
                    MessageBox.Show("Please select a type of bread.");
                    return string.Empty;
            }
        }
        public void Serializer(string fileName) 
        {
            try 
            {
                using (TextWriter writer = new StreamWriter(fileName)) 
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Bakery));
                    serializer.Serialize(writer, this);
                } 
            }
            catch (InvalidOperationException ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Error: " + ex.InnerException.Message.ToString());
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
            }
        }
        public void Deserializer(string fileName)
        {
            try
            {
                using (TextReader reader = new StreamReader(fileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Bakery));
                    Bakery deserializedBakery = (Bakery)serializer.Deserialize(reader);

                    this._name = deserializedBakery._name;
                    this.sandwiches = deserializedBakery.sandwiches;
                    this.ingredients = deserializedBakery.ingredients;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
        }
    }
}
