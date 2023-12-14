using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BickingTrip
{
    public partial class Form1 : Form
    {
        Destinations destinations;

        public Form1()
        {
            InitializeComponent();

            destinations = new Destinations();
            // Add some dummy trips
            destinations.Add(new Destination("Amsterdam", 4, "Bike", 121));
            destinations.Add(new Destination("Rome", 4, "Plane", 1532));
            destinations.Add(new Destination("Paris", 3.5, "Train", 447));
            btnShowAll_Click(this, EventArgs.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string destination = tbxTo.Text;
            double rating = Convert.ToDouble(nudRating.Value);
            string transport = tbxTransport.Text;
            double distance = Convert.ToDouble(nudDistance.Value);


            if (!String.IsNullOrEmpty(destination) && !String.IsNullOrEmpty(transport) && distance > 0)
            {
                destinations.Add(new Destination(destination, rating, transport, distance));

                btnShowAll_Click(this, EventArgs.Empty);
                tbxTo.Clear();
                tbxTransport.Clear();
                nudDistance.Value = 0m;
                nudRating.Value = 0m;
            }
            else
            {
                MessageBox.Show("Please supply a valid destination and/or distance");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxMyTrips.SelectedIndex > -1)
            {
                destinations.Remove(lbxMyTrips.SelectedItems[0].ToString());
            }
            btnShowAll_Click(this, EventArgs.Empty);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lbxMyTrips.SelectedIndex > -1)
            {
                MessageBox.Show(destinations.GetInfo(lbxMyTrips.SelectedIndex));
            }
            btnShowAll_Click(this, EventArgs.Empty);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbxMyTrips.Items.Clear();
            for (int i = 0; i < destinations.Count(); i++)
            { 
                lbxMyTrips.Items.Add(destinations.ToString(i));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            lbxMyTrips.Items.Clear();

            string query = tbxSearch.Text;
            for (int i = 0; i < destinations.Count(); i++)
            {
               if (destinations.GetDestination(i).Name.Contains(query))
                {
                    lbxMyTrips.Items.Add(destinations.ToString(i));
                }
            }
        }

    }
}
