using Bardcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bardcore.ViewModels
{
    public class ProfilePlaylistVM
    {
        
        public List<UserProfile> allProfiles { get; set; }
        public List<UserPlaylist> allPlaylists { get; set; }
        public List<UserPlaylistTrack> allPlaylistTracks { get; set; }
    }
}
