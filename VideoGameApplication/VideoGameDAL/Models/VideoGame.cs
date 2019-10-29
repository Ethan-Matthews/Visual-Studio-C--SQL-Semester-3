using System;

namespace VideoGameDAL.Models
{
    public class VideoGame
    {
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
    }
}
