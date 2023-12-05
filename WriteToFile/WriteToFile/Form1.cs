namespace WriteToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) 
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = tbxTitle.Text;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string title = tbxTitle.Text;
                    string content = tbxText.Text;

                    using (StreamWriter writer =  new StreamWriter(filePath)) 
                    {
                        writer.WriteLine($"Title: {title}");
                        writer.WriteLine("Content:");
                        writer.WriteLine(content);
                    }

                    MessageBox.Show("File saved succesfully.");
                }
            }
        }
    }
}