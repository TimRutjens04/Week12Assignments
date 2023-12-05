namespace RandomPasswordGenerator
{
    public partial class lbxCollection : Form
    {
        public lbxCollection()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int passwordLength = (int)(numCharacters.Value);
            int amountOfPasswords = (int)(numPasswords.Value);
            bool useSymbols = cbxSymbols.Checked;

            string[] generatedPasswords = PasswordGenerator.GeneratePasswords(passwordLength, amountOfPasswords, useSymbols);

            lbxPasswords.Items.Clear();
            lbxPasswords.Items.AddRange(generatedPasswords);
        }
    }


    public static class PasswordGenerator
    {
        public static string[] GeneratePasswords(int length, int count, bool includeSymbols)
        {
            string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/";

            string allCharacters = lowercaseLetters + uppercaseLetters + numbers;
            if (includeSymbols)
            {
                allCharacters += symbols;
            }
            Random random = new Random();
            string[] passwords = new string[count];

            for (int i = 0; i < count; i++) //amount of passwords
            {
                char[] passwordArray = new char[length];
                for (int j = 0; j < length; j++) //length of passwords
                {
                    int randomIndex = random.Next(0, allCharacters.Length);
                    passwordArray[j] = allCharacters[randomIndex];
                }
                passwords[i] = new string(passwordArray);
            }
            return passwords;
        }
    }
}