using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bardcore.Models
{
    public partial class Artist
    {
        public Artist()
        {
            Album = new HashSet<Album>();
            SongInfo = new HashSet<SongInfo>();
        }

        [Key]
        public int ArtistId { get; set; }
        public string ArName { get; set; }

        public ICollection<Album> Album { get; set; }
        public ICollection<SongInfo> SongInfo { get; set; }
    }
}
