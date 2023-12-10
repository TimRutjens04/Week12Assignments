using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public enum Genre
    {
        Rap,
        Pop,
        Rock,
        Country,
        Classical
    }
    public class Song
    {
        private int id;
        private string artist;
        private string title;
        private Genre genre;
        private int durationInSeconds;
        public Song(int id, string artist, string title, Genre genre, int durationInSeconds)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.genre = genre;
            this.durationInSeconds = durationInSeconds;

        }

        public int GetId()
        { return this.id; }

        public string GetArtist()
        { return this.artist; }

        public Genre GetGenre()
        {
            return this.genre;
        }

        public string GetInfo()
        {
            return $"ID {this.id:00}: {this.artist} - {this.title} ({this.durationInSeconds} seconds)";
        }
    }
}