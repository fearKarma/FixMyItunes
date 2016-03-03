namespace FixMyItunes
{
    internal class Album
    {
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private string albumName;

        public string AlbumName
        {
            get { return albumName; }
            set { albumName = value; }
        }

        private string trackTitle;

        public string TrackTitle
        {
            get { return trackTitle; }
            set { trackTitle = value; }
        }

        private string sortArtist;

        public string SortArtist
        {
            get { return sortArtist; }
            set { sortArtist = value; }
        }

        private string sortAlbum;

        public string SortAlbum
        {
            get { return sortAlbum; }
            set { sortAlbum = value; }
        }

        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        private int discNumber;

        public int DiscNumber
        {
            get { return discNumber; }
            set { discNumber = value; }
        }

        //constructor for Base List
        public Album(string artist, string album)
        {
            this.Artist = artist;
            this.AlbumName = album;
        }

        public Album(string artist, string album, string title, string sortArtist, string sortAlbum, string year, int discNumber)
        {
            this.Artist = artist;
            this.SortAlbum = sortAlbum;
            this.SortArtist = sortArtist;
            this.TrackTitle = trackTitle;
            this.Year = year;
            this.AlbumName = albumName;
            this.DiscNumber = discNumber;
        }


    }
}