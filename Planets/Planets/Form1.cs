using Microsoft.VisualBasic.ApplicationServices;

namespace Planets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEarth.Click += PlanetButtonClick;
            btnMars.Click += PlanetButtonClick;
            btnVenus.Click += PlanetButtonClick;
            btnMercury.Click += PlanetButtonClick;
            btnSaturn.Click += PlanetButtonClick;
        }

        private void PlanetButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string planetName = clickedButton.Text;
            lblPlanet.Text = planetName;

            //picture stuff:
            string imagePath = $"PlanetPictures/{planetName}.jpg";
            Image planetImage = Image.FromFile(imagePath);
            pbxPlanet.Image = planetImage;


            switch (planetName)
            {
                case "Earth":
                    tbxGravity.Text = "9,807m/s²";
                    tbxDiameter.Text = "12.742km";
                    break;
                case "Mars":
                    tbxGravity.Text = "3,71m/s²";
                    tbxDiameter.Text = "6.779km";
                    break;
                case "Venus":
                    tbxGravity.Text = "8,87m/s²";
                    tbxDiameter.Text = "12.104km";
                    break;
                case "Mercury":
                    tbxGravity.Text = "3,7m/s²";
                    tbxDiameter.Text = "4.879km";
                    break;
                case "Saturn":
                    tbxGravity.Text = "10,44m/s²";
                    tbxDiameter.Text = "116.464km";
                    break;

            }
        }


    }
}