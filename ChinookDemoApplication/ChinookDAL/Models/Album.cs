using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookDAL.Models
{
    public class Album
    {
        //SCALAR PROPERTIES
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }

        //NAVIGATION PROPERTIES
        private Artist _artist;
        public Artist Artist  //ONE
        { 
            get
            {
                if (_artist == null)
                {
                    //_artist = ArtistManager.GetArtistForAlbum(AlbumId);
                }

                return _artist;
            }
        }
    }
}
