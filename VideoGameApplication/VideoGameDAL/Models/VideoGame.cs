using System;

namespace VideoGameDAL.Models
{
    public class VideoGame
    {
        // Scalar Prperties.
        // Primary Key.
        public int GameID { get; set; }

        // Columns.
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TotalHoursPlayed { get; set; }
        public int NumberOfAchievemnets { get; set; }

        // Foreign Keys.
        public int DeveloperID { get; set; }
        public int GenreID { get; set; }

        // Navigation Properties.
        private Genre _genre_; // Single from Genre

        public Genre Genre
        {
            get
            {
                if (_genre_ == null) 
                {
                    _genre_ = GenreManager.GetGenre(GenreID);
                }
                return _genre_;
            }
        }

        private Developer _developer_;  // Single from Developer.

        public Developer Deveoper
        {
            get
            {
                if (_developer_ == null)
                {
                    _developer_ = DeveloperManager.GetDeveloper(DeveloperID);
                }
                return _developer_;
            }
        }
    }
}
