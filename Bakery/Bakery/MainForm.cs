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
        private Bakery bakery;
        private Sandwich sandwich;
        //private List<Sandwich> sandwiches = new List<Sandwich>();
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
                if (cbbBreadFilter.SelectedItem == null)
                {
                    MessageBox.Show("Please select a bread type");
                    return;
                }
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
                string sandwichName = lbxMenu.SelectedItem.ToString().Split('-')[1].Trim();

                Sandwich selectedSandwich = bakery.sandwiches.FirstOrDefault(s => s.GetName() == sandwichName);

                if (selectedSandwich != null)
                {
                    string ingredientInfo = selectedSandwich.LabelInfoIngredients();
                    lblSandwichInfo.Text = $"{selectedSandwich.GetName()}: {ingredientInfo}";
                }
                else
                {
                    lblSandwichInfo.Text = $"Selected sandwich '{sandwichName}' not found in the collection.";
                }
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

        private void btnSell_Click(object sender, EventArgs e)
        {
            var checkedItem = lbxMenu.SelectedItem;
            var sandwichString = checkedItem.ToString().Split('-')[2].Trim();
            bakery.SellSandwiches(sandwichString);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            bakery.IncludeVAT = cbxVAT.Checked;
            bakery.ShowRevenue();
        }
    }
}
