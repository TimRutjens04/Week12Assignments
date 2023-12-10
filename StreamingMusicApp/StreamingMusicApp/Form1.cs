namespace StreamingMusicApp
{
    public partial class Form1 : Form
    {
        User user;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            string userEmail = tbxUserRegisterEmail.Text;
            string userPassword = tbxUserRegisterPassword.Text;

            user = new User(userEmail, userPassword);
            User.CreateUser(userEmail, userPassword);
            lbxUserAllUsers.DataSource = null;
            lbxUserAllUsers.DataSource = User.GetAllUsers();
            lbxUserAllUsers.DisplayMember = nameof(User.Email);

            List<Song> userFavorites = user.GetFavoriteSongs();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            string userEmail = tbxUserLoginEmail.Text;
            string userPassword = tbxUserLoginPassword.Text;

            User.LoginUser(userEmail, userPassword);
            List<Song> userFavorites = user.GetFavoriteSongs();

            lblLoggedInUser.Text = $"Logged in user: {userEmail}";
        }

        private void btnSongsAddQueue_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSongsAddFavorites_Click(object sender, EventArgs e)
        {

        }

        private void btnSongsAddPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnSongsRemoveQueue_Click(object sender, EventArgs e)
        {

        }

        private void btnSongsQueueAddFavorites_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFavorites_Click(object sender, EventArgs e)
        {

        }

        
    }
}