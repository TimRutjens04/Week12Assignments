namespace ReadFromFile
{
    public partial class Form1 : Form
    {
        List<Person> list = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (openFileDialog1)
            {
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    try
                    {
                        string[] csvLines = File.ReadAllLines(filePath);
                        foreach (string line in csvLines)
                        {
                            try
                            {
                                Person person = new Person(line);
                                list.Add(person);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error reading file");
                            }
                        }
                        UpdateListBoxes();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void UpdateListBoxes()
        {
            lbxFirstName.Items.Clear();
            lbxLastName.Items.Clear();
            lbxEmail.Items.Clear();
            lbxGender.Items.Clear();
            lbxIP.Items.Clear();

            foreach (Person person in list)
            {
                lbxFirstName.Items.Add(person.First_name);
                lbxLastName.Items.Add(person.Last_name);
                lbxEmail.Items.Add(person.Email);
                lbxGender.Items.Add(person.Gender);
                lbxIP.Items.Add(person.Ip_adress);
            }
        }
    }

    public class Person
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Slogan { get; set; }
        public string Ip_adress { get; set; }

        public Person(string csvLine)
        {
            string[] values = csvLine.Split(',');
            if (values.Length >= 6)
            {
                First_name = values[0];
                Last_name = values[1];
                Email = values[2];
                Gender = values[3];
                //Slogan = values[4];
                Ip_adress = values[5];
            }
            else { throw new Exception("Invalid CSV format."); }


        }

    }
}