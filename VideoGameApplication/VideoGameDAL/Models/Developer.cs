using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDAL.Models
{
    public class Developer
    {
        // Primary Key.
        public int DeveloperID { get; set; }

        // Column.
        public string DeveloperName { get; set; }

        // Foreign Key.
        public string CountryCode { get; set; }
    }
}
