using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrazyRounding
{
    public partial class CrazyRounding : Form
    {
        List<double> numbers = new List<double>();

        public CrazyRounding()
        {
            InitializeComponent();
        }

        public static class CrazyMath
        {
            // Rounding 6.5 should have a 50/50 chance to go to 6 or 7
            private static Random random = new Random();

            public static double RandomChoice(double number)
            {
                const int timesAdded = 10;
                List<double> roundedNumbers = new List<double>();

                for (int i = 0; i < timesAdded; i++)
                {
                    double randomNumber = random.NextDouble();
                    double roundedValue = (randomNumber < 0.5) ? Math.Floor(number) : Math.Ceiling(number);
                    roundedNumbers.Add(roundedValue);
                }
                return roundedNumbers[0]; 
            }
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbxInput.Text, out double inputNumber))
            {
                const int timesAdded = 10;
                lbxCollection.Items.Clear();

                for (int i = 0; i < timesAdded; i++)
                {
                    double roundedNumber = CrazyMath.RandomChoice(inputNumber);

                    if (rbWhole.Checked)
                    {
                        roundedNumber = Math.Round(roundedNumber, 0);
                    }
                    else if (rbTenth.Checked)
                    {
                        roundedNumber = Math.Round(roundedNumber, 1);
                    }
                    else if (rbHundreth.Checked)
                    {
                        roundedNumber = Math.Round(roundedNumber, 2); 
                    }
                    else
                    {
                        MessageBox.Show("Please select a way to round.");
                    }

                    numbers.Add(roundedNumber);
                }

                foreach (var num in numbers)
                {
                    lbxCollection.Items.Add(num);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}

