namespace MusicStore.Models
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set;}
        public IEnumerable<Song>? Songs { get; set; }
    }
}
