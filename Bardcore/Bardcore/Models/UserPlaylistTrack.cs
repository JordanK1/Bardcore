using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bardcore.Models
{
    public partial class UserPlaylistTrack
    {
        [Key]
        public int PlaylistTrackId { get; set; }
        public int? PlaylistId { get; set; }
        public int? TrackId { get; set; }

        public UserPlaylist Playlist { get; set; }
        public SongInfo Track { get; set; }
    }
}
