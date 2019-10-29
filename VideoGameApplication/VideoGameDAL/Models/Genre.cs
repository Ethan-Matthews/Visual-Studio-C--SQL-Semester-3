using System.Collections.Generic;

namespace VideoGameDAL.Models
{
    public class Genre
    {   
        // Scalar Properties.
        // Primary Key.
        public int GenreID { get; set; }

        // Column.
        public string GenreName { get; set; }

        // Navigation Properties.
        private List<VideoGame> _videogames_; // Multiple from videogames.

        public List<VideoGame> videoGame
        { 
            get
            {
                if (_videogames_ == null)
                {
                    _videogames_ = VideoGameManager.GetGenreGames(GenreID);
                }
                return _videogames_;
            }
                
        }

    }
}