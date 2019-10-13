using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameDAL;
using VideoGameDAL.Models;

namespace TestHarness
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Genre genreGet = GenreManager.GetGenre(1);
            Console.WriteLine(genreGet.GenreName);

            Genre g = new Genre();
            g.GenreName = "NewGenre";
            GenreManager.InsertGenre(g);

            List<Genre> genres = GenreManager.GetGenreList();
            foreach (Genre genre in genres)
            {
                Console.WriteLine(genre.GenreName);
            }

            GenreManager.UpdateGenre(g);

            Console.Read();

            GenreManager.DeleteGenre(g.GenreID);

            List<Genre> genres2 = GenreManager.GetGenreList();
            foreach (Genre genre in genres2)
            {
                Console.WriteLine(genre.GenreName);
            }

            Console.Read();

            //List<Genre> genres = GenreManager.GetGenreList();
            //foreach (Genre genre in genres)
            //{
            //    Console.WriteLine(genre.GenreName);
            //}
            //Console.WriteLine("-----------------------------\n");

            //List<DeveloperCountry> developerCountries = DeveloperCountryManager.GetDeveloperCountryList();
            //foreach (DeveloperCountry developerCountry in developerCountries)
            //{
            //    Console.WriteLine(developerCountry.CountryName);
            //}
            //Console.WriteLine("-----------------------------\n");

            //List<Developer> developers = DeveloperManager.GetDeveloperList();
            //foreach (Developer developer in developers)
            //{
            //    Console.WriteLine(developer.DeveloperName);
            //}
            //Console.WriteLine("-----------------------------\n");

            //List<VideoGame> videoGames = VideoGameManager.GetVideoGameList();
            //foreach (VideoGame videoGame in videoGames)
            //{
            //    Console.WriteLine(videoGame.Title);
            //}
            //Console.Read();

            //Developer developer = DeveloperManager.GetDeveloper(1);

            //if (developer != null)
            //{
            //    Console.WriteLine(developer.DeveloperID);
            //}
            //else
            //{
            //    Console.WriteLine("Video ID not found");
            //}

            //DeveloperCountry DeveloperCountry = DeveloperCountryManager.GetDeveloperCountry("CAN");

            //if (developer != null)
            //{
            //    Console.WriteLine(DeveloperCountry.CountryName);
            //}
            //else
            //{
            //    Console.WriteLine("Video ID not found");
            //}

            //Genre genre = GenreManager.GetGenre(3);

            //if (genre != null)
            //{
            //    Console.WriteLine(genre.GenreName);
            //}
            //else
            //{
            //    Console.WriteLine("Video ID not found");
            //}

            //Console.WriteLine("Enter a videoGame ID: ");
            //string videoGameID = Console.ReadLine();
            //VideoGame videoGame = VideoGameManager.GetVideoGame(int.Parse(videoGameID));

            //if (videoGame != null)
            //{
            //    Console.WriteLine(videoGameID);
            //}
            //else
            //{
            //    Console.WriteLine("Video ID not found");
            //}

            //Console.WriteLine("Enter a category ID: ");
            //string genreID = Console.ReadLine();
            //Genre genre = GenreManager.GetGenre(int.Parse(genreID));

            //if (genre != null) 
            //{
            //    Console.WriteLine(genre.GenreName);
            //}
            //else
            //{
            //    Console.WriteLine("Genre ID not found");
            //}
        }
    }
}
