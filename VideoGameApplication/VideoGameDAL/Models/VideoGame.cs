using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDAL.Models
{
    public class VideoGame
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public int NumberOfAchievemnets { get; set; }
        public int DeveloperID { get; set; }
        public int GenreID { get; set; }
    }
}
