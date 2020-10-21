using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bardcore.Models
{
    public partial class SongInfo
    {
        public SongInfo()
        {
            UserPlaylistTrack = new HashSet<UserPlaylistTrack>();
        }

        [Key]
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int? ArtistName { get; set; }
        public int? GenreName { get; set; }
        public int? AlbumName { get; set; }
        public short? ReleaseYear { get; set; }
        public int? Uploader { get; set; }
        public DateTime UploadDate { get; set; }
        public string FileLocation { get; set; }

        [ForeignKey("AlbumName")]
        public Album AlbumNameNavigation { get; set; }
        
        [ForeignKey("ArtistName")]
        public Artist ArtistNameNavigation { get; set; }
        
        [ForeignKey("GenreName")]
        public Genre GenreNameNavigation { get; set; }

        [ForeignKey("Uploader")]
        public UserProfile UploaderNavigation { get; set; }
        public ICollection<UserPlaylistTrack> UserPlaylistTrack { get; set; }
    }
}
