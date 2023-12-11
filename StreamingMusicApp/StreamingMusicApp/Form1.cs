using System.Net;
using System.Text.RegularExpressions;

namespace StreamingMusicApp
{
    public partial class Form1 : Form
    {
        User user;
        StreamingMusicService service = new StreamingMusicService("service"); 
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

        private void RefreshQueue()
        {
            Song[] allSongs = service.GetSongs();

            clbxSongsQueue.Items.Clear();

            foreach (Song song in allSongs)
            {
                clbxSongsQueue.Items.Add(song.GetInfo()); 
            }
        }

        private void RefreshFavorites() 
        {
            Song[] allSongs = service.GetSongs();

            clbxFavoritesList.Items.Clear();

            foreach (Song song in allSongs) 
            {
                clbxFavoritesList.Items.Add(song.GetInfo());
            }
        }


        private void btnSongsAddQueue_Click(object sender, EventArgs e)
        {
            string artist = tbxSongsArtist.Text;
            string title = tbxSongsTitle.Text;
            Genre genre;
            if (!Enum.TryParse(cbxSongsGenre.SelectedItem.ToString(), out genre)) 
            {
                MessageBox.Show("Invalid genre, select one that is provided.");
            }
            int durationInSeconds = (int)numSongsDuration.Value;

            if (string.IsNullOrWhiteSpace(artist) || string.IsNullOrWhiteSpace(title) || (numSongsDuration.Value == 0))
            {
                MessageBox.Show("Please fill in all the song details.");
                return;
            }

            service.AddSong(artist, title, genre, durationInSeconds);

            MessageBox.Show($"Song added to the music service: {artist} - {title} - {genre} - {durationInSeconds}");
            RefreshQueue();
        }


        private void btnSongsAddFavorites_Click(object sender, EventArgs e)
        {
            int id;
            string artist = tbxSongsArtist.Text;
            string title = tbxSongsTitle.Text;
            Genre genre;
            if (!Enum.TryParse(cbxSongsGenre.SelectedItem.ToString(), out genre))
            {
                MessageBox.Show("Invalid genre, select one that is provided.");
            }
            int durationInSeconds = (int)numSongsDuration.Value;

            if (string.IsNullOrWhiteSpace(artist) || string.IsNullOrWhiteSpace(title) || (numSongsDuration.Value == 0))
            {
                MessageBox.Show("Please fill in all the song details.");
                return;
            }

            //Song selectedSong = service.GetSong(id);            
            
            MessageBox.Show("Song added to favorites.");
            RefreshFavorites();
        }

        private void btnSongsAddPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnSongsRemoveQueue_Click(object sender, EventArgs e)
        {
            if (clbxSongsQueue.CheckedItems.Count > 0)
            {
                foreach (object checkedItem in clbxSongsQueue.CheckedItems)
                {
                    string songInfo = checkedItem.ToString();

                    string idSubstring = Regex.Match(songInfo, @"\d+").Value; //found this on a forum, am using this to make sure only numeric values are passed to the TryParse

                    if (int.TryParse(idSubstring, out int songID))
                    {
                        service.RemoveSong(songID);
                    }
                }

                RefreshQueue(); 
            }
        }




        private void btnSongsQueueAddFavorites_Click(object sender, EventArgs e)
        {
            if (clbxSongsQueue.CheckedItems.Count > 0)
            {
                foreach (object checkedItem in clbxSongsQueue.CheckedItems)
                {
                    string songInfo = checkedItem.ToString();
                    int songID = int.Parse(songInfo.Substring(songInfo.IndexOf("ID")));

                    Song selectedSong = service.GetSong(songID);

                    if (selectedSong != null)
                    {
                        user.AddSongToFavorites(selectedSong);
                        clbxFavoritesList.Items.Add(selectedSong);
                    }
                }
            }
            MessageBox.Show("Song added to favorites.");
        }

        private void btnRemoveFavorites_Click(object sender, EventArgs e)
        {
            if (clbxFavoritesList.CheckedItems.Count > 0)
            {
                List<object> itemsToRemove = new List<object>();

                foreach (object checkedItem in clbxFavoritesList.CheckedItems)
                {
                    if (checkedItem is Song selectedSong)
                    {
                        user.RemoveSongFromFavorites(selectedSong);
                        itemsToRemove.Add(checkedItem);
                    }
                }

                foreach (var itemToRemove in itemsToRemove)
                {
                    clbxFavoritesList.Items.Remove(itemToRemove);
                }

                RefreshFavorites(); // Refresh the favorites list after removal
            }
        }




    }
}