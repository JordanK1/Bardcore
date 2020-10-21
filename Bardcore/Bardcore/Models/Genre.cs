using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bardcore.Models
{
    public partial class Genre
    {
        public Genre()
        {
            SongInfo = new HashSet<SongInfo>();
        }

        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }

        public ICollection<SongInfo> SongInfo { get; set; }
    }
}
