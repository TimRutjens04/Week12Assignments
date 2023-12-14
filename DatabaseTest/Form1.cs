using System.Data.SqlClient;
namespace DatabaseTest

{
    public partial class Form1 : Form
    {
        private SqlConnection conn =
            new SqlConnection("server=mssqlstud.fhict.local;" +
                              "database =dbi535094_s1s;" +
                              "user id =dbi535094_s1s;" +
                              "password =test;");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            string sql = "SELECT username, email FROM [user] ORDER BY email;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            //List<string> list = new List<string>();
            string message = "";
            
            while (reader.Read()) 
            {
                string username = reader[0].ToString();
                string email = reader[1].ToString();
                message += username + " " + email + "\n";
            }
            conn.Close();

            MessageBox.Show(message);
        }
    }
}