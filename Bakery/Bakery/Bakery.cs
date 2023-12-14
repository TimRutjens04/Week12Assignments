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
using System.Globalization;

namespace Bakery
{
    [DataContract]
    public class Bakery
    {
        [DataMember]
        public string _name;
        [DataMember]
        private const double VAT_PERCENTAGE = 1.09;
        [DataMember]
        public List<Sandwich> sandwiches { get; set; }
        [DataMember]
        public List<Ingredient> ingredients { get; set; }
        [DataMember]
        public List<double> soldSandwiches { get; set; }
        private bool _VAT = false;

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
        public bool IncludeVAT 
        {
            get { return _VAT; } 
            set { _VAT = value;}
        }

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
        public void SellSandwiches(string sandwichString) 
        {
            if (double.TryParse(sandwichString.Replace("€", ""),
                NumberStyles.Currency, CultureInfo.CurrentCulture,
                out double sandwichRevenue)) 
            {
                soldSandwiches.Add(sandwichRevenue);
            }
            else { MessageBox.Show("Failed to parse due to currency conflicts."); }
        }

        public double CalculateRevenue()
        {
            double totalRevenue = soldSandwiches.Sum(); //this line breaks when no bakery is selected
            if (IncludeVAT) 
            {
                totalRevenue = totalRevenue * VAT_PERCENTAGE;
                return totalRevenue;
            }
            return totalRevenue;
        }

        public void ShowRevenue() 
        {
            double totalRevenue = CalculateRevenue();
            string message;
            if (IncludeVAT) 
            {
                message = $"Total revenue for {_name} is {totalRevenue:C} (including VAT)";
            }
            else 
            {
                message = $"Total revenue for {_name} is {totalRevenue:C} (excluding VAT)";
            }
            MessageBox.Show(message);
        }
        
        public void getFromDatabase(Bakery databaseBakery, 
                                    List<Sandwich> databaseSandwiches, 
                                    List<Ingredient> databaseIngredients) 
        {
            using (SqlConnection conn = new SqlConnection("server=mssqlstud.fhict.local;" +
                                                          "database =dbi535094_bakery;" +
                                                          "user id =dbi535094_bakery;" +
                                                          "password =bakery;")) 
            {
                string sqlBakery = "SELECT ";
                string sqlSandwiches = "SELECT";
                string sqlIngredients = "SELECT";
            }
        }
        //maybe useful for the future:
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
