using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bardcore.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bardcore.ViewModels
{
    public class ProfilePlaylistVM
    {

        public UserProfile DisplayName;
        public UserPlaylist PlaylistCreator;
        public UserPlaylist PlaylistName;
    }
}
