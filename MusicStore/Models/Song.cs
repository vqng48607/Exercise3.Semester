using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace MusicStore.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? PlaylistId { get; set; }
        public Playlist? Playlist { get; set; }
        public int AlbumId { get; set; }
        public Album? Album { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
