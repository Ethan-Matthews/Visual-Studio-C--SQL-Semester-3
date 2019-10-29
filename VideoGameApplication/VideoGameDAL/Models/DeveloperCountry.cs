using System.Collections.Generic;

namespace VideoGameDAL.Models
{
    public class DeveloperCountry
    {
        // Scalar Properties.
        // Primary Key.
        public string CountryCode { get; set; }

        // Column.
        public string CountryName { get; set; }

        // Navigation Properties.
        private List<Developer> _developers_;  // Multiple from Developers.

        public List<Developer> Developer
        {
            get
            {
                if (_developers_ == null)
                {
                    _developers_ = DeveloperManager.GetDevelopersWithCountryCode(CountryCode);
                }
                return _developers_;
            }

        }
    }
}
