using System.Collections.Generic;

namespace VideoGameDAL.Models
{
    public class Developer
    {
        // Scalar Properties.
        // Primary Key.
        public int DeveloperID { get; set; }

        // Column.
        public string DeveloperName { get; set; }

        // Foreign Key.
        public string CountryCode { get; set; }

        // Navigation Properties.
        private List<VideoGame> _videogames_;  // Multiple from VideoGames.

        public List<VideoGame> videoGame
        {
            get
            {
                if (_videogames_ == null)
                {
                    _videogames_ = VideoGameManager.GetDeveloperGames(DeveloperID);
                }
                return _videogames_;
            }

        }

        private DeveloperCountry _developerCountry_; //  Single from Developer Countries.

        public DeveloperCountry DeveloperCountry
        {
            get
            {
                if (_developerCountry_ == null)
                {
                    _developerCountry_ = DeveloperCountryManager.GetDeveloperCountry(CountryCode);
                }
                return _developerCountry_;
            }
        }
    }
}
