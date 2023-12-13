using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Bakery
{
    public enum BreadType
    {
        CIABATTA,
        FOCACCIA,
        SOUR_DOUGH,
        RYE,
        WHOLE_WHEAT
    }


    public partial class MainForm : Form
    {
        private string connectionString = "Your_Connection_String_Here";
        private Bakery bakery;
        private Sandwich sandwich;
        private List<Sandwich> sandwiches = new List<Sandwich>();
        //private DataContractSerializer serializer;
        private XmlSerializer serializer = new XmlSerializer(typeof(Bakery));

        public MainForm()
        {
            InitializeComponent();

            // Init GUI
            //lblSandwichInfo.Text = String.Empty;

            List<Sandwich> sandwiches = new List<Sandwich>();
            List<Ingredient> ingredients = new List<Ingredient>();
            bakery = new Bakery("Company", sandwiches, ingredients);
        }

        private void btnAddSandwich_Click(object sender, EventArgs e)
        {
            if (bakery != null)
            {
                AddForm addform = new AddForm(bakery);
                addform.Show();
            }
            else { MessageBox.Show("Create a bakery instance first."); }
        }

        private void btnShowOfferedSandwiches_Click(object sender, EventArgs e)
        {
            if (bakery != null)
            {
                string selectedBread = cbbBreadFilter.SelectedItem.ToString();
                if (Enum.TryParse(selectedBread, out BreadType bread)) { }
                else { MessageBox.Show("Invalid bread type"); }
                bakery.GetAvailableSandwiches(bread);
                UpdateSandwichListbox();

            }
        }
        private void UpdateSandwichListbox()
        {
            string selectedBread = cbbBreadFilter.SelectedItem.ToString();
            if (Enum.TryParse(selectedBread, out BreadType sandwichBread)) { }
            else { MessageBox.Show("Invalid bread type"); }
            List<string> displayInfoList = bakery.GetAvailableSandwiches(sandwichBread)
                                                .Select(sandwich => sandwich.DisplayInfoSandwich())
                                                .ToList();

            lbxMenu.DataSource = null;
            lbxMenu.DataSource = displayInfoList;
        }
        private void lbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxMenu.SelectedItem != null)
            {
                string selectedDisplayInfo = lbxMenu.SelectedItem.ToString().Trim();

                // Debugging statement to check the selected display info
                Debug.WriteLine($"Selected Display Info: {selectedDisplayInfo}");

                List<Sandwich> matchingSandwiches = sandwiches
                    .Where(s => string.Equals(s.DisplayInfoSandwich().Trim(), selectedDisplayInfo, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Debugging statement to check the number of matching sandwiches
                Debug.WriteLine($"Number of Matching Sandwiches: {matchingSandwiches.Count}");

                // Initialize a variable to store sandwich information
                string sandwichInfo = "";

                foreach (var selectedSandwich in matchingSandwiches)
                {
                    // Debugging statement to check the display info for each matching sandwich
                    Debug.WriteLine($"Matching Sandwich Display Info: {selectedSandwich.DisplayInfoSandwich()}");

                    string displayName = selectedSandwich.GetName();
                    List<string> displaySelectedIngredientList = selectedSandwich.GetIngredients()
                        .Select(ingredient => ingredient.DisplayInfoIngredient())
                        .ToList();

                    string ingredientInfo = string.Join("\n", displaySelectedIngredientList);

                    sandwichInfo += $"{displayName}\n{ingredientInfo}\n";
                }

                // Debugging statement to check the final sandwich information
                Debug.WriteLine($"Final Sandwich Info: {sandwichInfo}");

                lblSandwichInfo.Text = string.IsNullOrEmpty(sandwichInfo) ? "No matching sandwich found." : sandwichInfo;
            }
            else
            {
                lblSandwichInfo.Text = "No sandwich selected.";
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            fdSave.Filter = "XML Files|*.xml";
            fdSave.Title = "Save Dakery Data";
            if (fdSave.ShowDialog() == DialogResult.OK) 
            {
                string fileName = fdSave.FileName;  
                using (FileStream fs = new(fileName, FileMode.Create, FileAccess.Write))
                {
                    try
                    {
                        serializer.Serialize(fs, bakery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving data \n" + ex.Message);
                    }
                }
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            fdOpen.Filter = "XML Files|*.xml";
            if (fdOpen.ShowDialog() == DialogResult.OK)
            {
                string fileName = fdOpen.FileName;
                using (FileStream fs = new(fileName, FileMode.Open, FileAccess.Read))
                    {
                        try
                        {
                            Bakery? _bakery = (Bakery?)serializer.Deserialize(fs);
                            if (_bakery != null)
                            {
                                this.bakery = _bakery;
                            }
                            else
                            {
                                throw new Exception("Deserialized object is null");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading data " + ex.Message);
                        }
                    }
            }
        }


    }
}

