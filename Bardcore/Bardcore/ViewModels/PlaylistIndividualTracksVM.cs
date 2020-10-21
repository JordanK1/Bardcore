using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bardcore.Models;

namespace Bardcore.ViewModels
{
    public class PlaylistIndividualTracksVM
    {

        public UserPlaylist userPlaylist;
        public IEnumerable<UserPlaylistTrack> userPlaylistTracks;
        public SongInfo songInfo;

        public PlaylistIndividualTracksVM()
        {
        }

    }
}
