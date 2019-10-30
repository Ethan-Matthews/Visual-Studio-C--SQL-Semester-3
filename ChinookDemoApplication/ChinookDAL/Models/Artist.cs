using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookDAL.Models
{
    public class Artist
    {
        //SCALAR PROPERTIES
        public int ArtistId { get; set; }
        public string Name { get; set; }

        //NAVIGATION PROPERTIES
        private List<Album> _albums;
        public List<Album> Albums
        { //MANY
            get
            {
                if (_albums == null)
                {
                    //TODO: FINISH
                    //_albums = AlbumManager.GetArtistAlbums(ArtistId);
                }

                return _albums;
            }
        }
    }
}
