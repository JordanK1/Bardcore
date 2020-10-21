using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bardcore.Models
{
    public partial class Album
    {
        public Album()
        {
            SongInfo = new HashSet<SongInfo>();
        }

        [Key]
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public int? ArtistName { get; set; }

        public Artist ArtistNameNavigation { get; set; }
        public ICollection<SongInfo> SongInfo { get; set; }
    }
}
