namespace PizzaToppingsExc
{
    public partial class Form1 : Form
    {
        private int amountOfToppings = 7;
        private string[] toppings;
        private double toppingPrice = 0.50;
        private double totalPrice = 5;
        enum Toppings
        {
            Ham,
            Mushrooms,
            Pepperoni,
            ExtraCheese,
            Onions,
            Chicken,
            Peppers
        }
        new List<Toppings> selectedToppings = new List<Toppings>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxToppings.SelectedIndex >= 0)
            {
                Toppings selectedTopping = (Toppings)cbxToppings.SelectedIndex;
                selectedToppings.Add(selectedTopping);
                lblTopping.Text = $"Toppings: {string.Join(", ", selectedToppings)}";
                totalPrice = totalPrice + toppingPrice;
                lblPrice.Text = $"Price: €{totalPrice}";
            }
            else { MessageBox.Show("Select a topping."); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedToppings.Count >= 1)
            {
                selectedToppings.RemoveAt(selectedToppings.Count - 1);
                lblTopping.Text = $"Toppings: {string.Join(", ", selectedToppings)}";
                totalPrice = totalPrice - toppingPrice;
                if (selectedToppings.Count != 0)
                {
                    lblPrice.Text = $"Price: €{totalPrice}";
                }
                else { lblPrice.Text = "Price: €0 "; }
            }
            else { MessageBox.Show("There are currently no toppings on the pizza."); }
        }
    }
}