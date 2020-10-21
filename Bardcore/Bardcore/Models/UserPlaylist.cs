using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bardcore.Models
{
    public partial class UserPlaylist
    {
        public UserPlaylist()
        {
            UserPlaylistTrack = new HashSet<UserPlaylistTrack>();
        }

        [Key]
        public int PlaylistId { get; set; }
        public int? PlaylistCreator { get; set; }
        public string PlaylistName { get; set; }

        public UserProfile PlaylistCreatorNavigation { get; set; }
        public ICollection<UserPlaylistTrack> UserPlaylistTrack { get; set; }
    }
}
