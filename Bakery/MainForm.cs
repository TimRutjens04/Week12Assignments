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
        public MainForm()
        {
            InitializeComponent();

            // Init GUI
            lblSandwichInfo.Text = String.Empty;
        }
    }
}
