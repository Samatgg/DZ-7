namespace Тумаков_8лаб
{
    internal class Song
    {
        private string songName;
        private string songAuthor;
        private Song lastSong;

        public string SongName
        {
            get
            {
                return songName;
            }
        }
        public string SongAuthor
        {
            get
            {
                return songAuthor;
            }
        }
        public Song LastSong
        {
            get
            {
                return lastSong;
            }
        }
        public string Title
        {
            get
            {
                return SongName + " - " + songAuthor;
            }
        }
        public override bool Equals(object d)
        {
            Song other = d as Song;
            if ((SongName == songName) && (SongAuthor == songAuthor) && (other != null))
            {
                return true;
            }
            else
            {
                return false;
            }                   
        }
        public override int GetHashCode()
        {
            return songName.GetHashCode();
        }
        public Song(string songName,string songAuthor)
        {
            this.songName = songName;
            this.songAuthor = songAuthor;
            lastSong = null;
        }
        public Song(string songName, string songAuthor, Song lastSong)
        {
            this.songName = songName;
            this.songAuthor = songAuthor;
            this.lastSong = lastSong;
        }
    }
}
