namespace Modul10_103022400056
{
    public class Game
    {
        public string Nama { get; set; }
        public string Developer { get; set; }
        public string TahunRilis { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string[] Platform { get; set; }
        public string[] Mode { get; set; }
        public bool IsOnline { get; set; }
        public int Harga { get; set; }

        public Game(string nama, string developer, string tahunRilis, string genre, double rating, string[] platform, string[] mode, bool isOnline, int harga)
        {
            this.Nama = nama;
            this.Developer = developer;
            this.TahunRilis = tahunRilis;
            this.Genre = genre;
            this.Rating = rating;
            this.Platform = platform;
            this.Mode = mode;
            this.IsOnline = isOnline;
            this.Harga = harga;
        }
    }
}