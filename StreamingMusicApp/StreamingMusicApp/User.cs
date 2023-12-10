using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    internal class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        private static List<User> userlist = new List<User>();
        private List<Song> favorites = new List<Song>();

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
            userlist.Add(this);
        }

        public void AddSongToFavorites(Song song)
        {
            if (!favorites.Any(s => s.GetId() == song.GetId()))
            {
                favorites.Add(song);
            }
        }

        public void RemoveSongFromFavorites(Song song)
        {
            favorites.Remove(song);
        }

        public List<Song> GetFavoriteSongs()
        {
            return favorites;
        }

        public static List<User> GetAllUsers() 
        {
            return userlist;
        }

        public static void CreateUser(string email, string password)
        {
            if (!userlist.Any(u => u.Email == email))
            {
                userlist.Add(new User(email, password));
            }
        }

        public static void LoginUser(string email, string password) 
        {
            var user = userlist.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                if (user.Password == password)
                {
                    MessageBox.Show($"Login succesfull. Welcome back {email}");
                }
                else { MessageBox.Show("Login unsuccesfull, enter a different password."); }
            }
            else { MessageBox.Show("Account not found, consider creating an account."); }
        }
    }
}
