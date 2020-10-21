using Bardcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bardcore.ViewModels
{
    public class MusicInformationVM
    {

        List<SongInfo> allSongInfo { get; set; }
        List<Album> allAlbums { get; set; }
        List<Artist> allArtists { get; set; }
        List<Genre> allGenres { get; set; }
    }
}
