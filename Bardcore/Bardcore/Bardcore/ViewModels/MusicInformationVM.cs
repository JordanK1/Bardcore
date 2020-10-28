using Bardcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bardcore.ViewModels
{
    public class MusicInformationVM
    {

        public int TrackID;
        public string Name;
        public int ArtistName;
        public int GenreName;
        public int AlbumName;
        public Int16 ReleaseYear;
        public int Uploader; 
        public DateTime UploadDate;
        public string FileLocation;
    }

    public class Artist
    {
        public int ArtistID;
        public string ArName;
    }

    public class Genre
    {
        public int GenreID;
        public string GName;
    }

    public class Album
    {
        public int AlbumID;
        public string AlName;
    }

    public class UserProfile
    {
        public int Userid;
        public string DisplayName;
        public string user_account_id;
    }


}
