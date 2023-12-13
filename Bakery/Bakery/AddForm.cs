using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddForm : Form
    {
        private Bakery bakery;
        //private Sandwich _sandwich;

        public AddForm(Bakery b)
        {
            InitializeComponent();
            bakery = b;
            clbxIngredients.Items.Clear();
            UpdateIngredientsListbox();
        }

        private void UpdateIngredientsListbox()
        {
            List<string> displayInfoList = bakery.GetAvailableIngredients()
                                                .Select(ingredient => ingredient.DisplayInfoIngredient())
                                                .ToList();

            clbxIngredients.DataSource = null;
            clbxIngredients.DataSource = displayInfoList;
        }       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clbxIngredients.CheckedItems.Count > 0 && clbxIngredients.CheckedItems.Count <= 5)
            {
                string sandwichName = tbxName.Text;
                string selectedBread = cbbBreadFilter.SelectedItem.ToString();
                if (Enum.TryParse(selectedBread, out BreadType sandwichBread)) { }
                else { MessageBox.Show("Invalid bread type"); }

                List<Ingredient> sandwichIngredients = new List<Ingredient>();

                foreach (var checkedItem in clbxIngredients.CheckedItems)
                {
                    var ingredientName = checkedItem.ToString().Split('-')[0].Trim();
                    var ingredient = bakery.GetAvailableIngredients().FirstOrDefault(i => i.GetName() == ingredientName);
                    if (ingredient != null)
                    {
                        sandwichIngredients.Add(ingredient);
                    }
                }
                double basePrice = 7;
                Sandwich sandwich = new Sandwich(sandwichName, basePrice, sandwichBread, sandwichIngredients);
                double sandwichPrice = sandwich.CalculateTotalPrice();
                sandwich.SetPrice(sandwichPrice);
                bakery.AddSandwich(sandwich);
                this.Close();
            }
            else { MessageBox.Show("Please make sure your sandwich has at least 1 topping and 5 at most."); }
        }
    }
}
