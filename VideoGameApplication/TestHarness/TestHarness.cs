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
            // Tests Completed.
            #region "GENRE TESTS"

            #region "UPDATE GENRE TEST"

            //Genre genre = new Genre();
            //genre.GenreID = 35;
            //genre.GenreName = "New Genre Name";

            //int rowsAffected = GenreManager.UpdateGenre(genre);
            //Console.WriteLine("Update complete: {0} row(s) affected", rowsAffected);

            #endregion

            #region "DELETE GENRE TEST"

            //int rows = GenreManager.DeleteGenre(8);
            //Console.WriteLine(rows);

            #endregion

            #region "INSERT NEW GENRE TEST"

            //Genre genreInsert = new Genre();
            //genreInsert.GenreName = "The Newest Genre";

            //Genre newGenre = GenreManager.InsertGenre(genreInsert);
            //Console.WriteLine(string.Format("The new Genre Name is {0} at ID {1}", newGenre.GenreName, newGenre.GenreID));

            #endregion

            #region "GET ONE GENRE BY ID TEST"

            //Console.Write("enter a genre id: ");
            //string genreID = Console.ReadLine();

            //Genre genreOne = GenreManager.GetGenre(int.Parse(genreID));
            //if (genreOne != null)
            //{
            //    Console.WriteLine(genreOne.GenreName);
            //}
            //else
            //{
            //    Console.WriteLine("Genre id not found");
            //}

            #endregion

            #region "GET ALL GENRES TEST"

            //List<Genre> genres = GenreManager.GetGenreList();
            //if (genres.Count() > 0)
            //{
            //    foreach (Genre genreInList in genres)
            //    {
            //        Console.WriteLine(genreInList.GenreName + " : " + genreInList.GenreID);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Genres were found.");
            //}

            #endregion

            #endregion

            // Tests Completed.
            #region "DEVELOPER COUNTRY TESTS"

            #region "UPDATE DEVELOPERCOUNTRY TEST"

            //DeveloperCountry developerCountry = new DeveloperCountry();
            //developerCountry.CountryCode = "USA";
            //developerCountry.CountryName = "Updated Country Name";


            //int rowsAffected = DeveloperCountryManager.UpdateDeveloperCountry(developerCountry);
            //Console.WriteLine("Update complete: {0} row(s) affected", rowsAffected);

            #endregion

            #region "DELETE DEVELOPERCOUNTRY TEST"

            //int rows = DeveloperCountryManager.DeleteDeveloperCountry("CAN");
            //Console.WriteLine("Lines affected: " + rows + "\n");

            #endregion

            #region "INSERT NEW DEVELOPERCOUNTRY TEST"

            //DeveloperCountry developerCountryInsert = new DeveloperCountry();
            //developerCountryInsert.CountryCode = "NCC";
            //developerCountryInsert.CountryName = "New Country";

            //DeveloperCountry newDeveloperCountry = DeveloperCountryManager.InsertDeveloperCountry(developerCountryInsert);
            //Console.WriteLine(string.Format("The new developerCountry code is: {0}\n" +
            //                                "The new country name is: {1}\n",
            //                                newDeveloperCountry.CountryCode,
            //                                newDeveloperCountry.CountryName));

            #endregion

            #region "GET ONE DEVELOPERCOUNTRY BY COUNTRYCODE TEST"

            //Console.Write("Enter a developer country code: ");
            //string countryCode = Console.ReadLine();

            //DeveloperCountry developerCountryOne = DeveloperCountryManager.GetDeveloperCountry(countryCode);
            //if (developerCountryOne != null)
            //{
            //    Console.WriteLine("\n" + developerCountryOne.CountryName + "\n");
            //}
            //else
            //{
            //    Console.WriteLine("Country Code not found");
            //}

            #endregion

            #region "GET ALL DEVELOPERCOUNTRIES TEST"

            //List<DeveloperCountry> developerCountries = DeveloperCountryManager.GetDeveloperCountryList();
            //if (developerCountries.Count() > 0)
            //{
            //    foreach (DeveloperCountry countryInList in developerCountries)
            //    {
            //        Console.WriteLine(countryInList.CountryCode + " : " + countryInList.CountryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Developer Countries were found.");
            //}


            #endregion

            #endregion

            // Tests Completed.
            #region "DEVELOPER TESTS"

            #region "UPDATE DEVELOPER TEST"

            //Developer developer = new Developer();
            //developer.DeveloperID = 2;
            //developer.DeveloperName = "New Developer Name";
            //developer.CountryCode = "CAN";

            //int rowsAffected = DeveloperManager.UpdateDeveloper(developer);
            //Console.WriteLine("Update complete: {0} row(s) affected", rowsAffected);

            #endregion

            #region "DELETE DEVELOPER TEST"

            //int rows = DeveloperManager.DeleteDeveloper(2);
            //Console.WriteLine(rows);

            #endregion

            #region "INSERT NEW DEVELOPER TEST"

            //Developer developerInsert = new Developer();
            //developerInsert.DeveloperName = "New Developer";
            //developerInsert.CountryCode = "CAN";

            //Developer newDeveloper = DeveloperManager.InsertDeveloper(developerInsert);
            //Console.WriteLine(string.Format("The new developer ID is {0}\n" +
            //                                "The new developer name is: {1}" +
            //                                "The new Developer CountryCode is: {2}\n",
            //                                newDeveloper.DeveloperID,
            //                                newDeveloper.DeveloperName,
            //                                newDeveloper.CountryCode));

            #endregion

            #region "GET ONE DEVELOPER BY ID TEST"

            //Console.Write("Enter a developer ID: ");
            //string developerID = Console.ReadLine();

            //Developer developerOne = DeveloperManager.GetDeveloper(int.Parse(developerID));
            //if (developerOne != null)
            //{
            //    Console.WriteLine(developerOne.DeveloperName);
            //}
            //else
            //{
            //    Console.WriteLine("Developer ID not found");
            //}

            #endregion

            #region "GET ALL DEVELOPERS TEST"

            //List<Developer> developers = DeveloperManager.GetDeveloperList();
            //if (developers.Count() > 0)
            //{
            //    foreach (Developer developerInList in developers)
            //    {
            //        Console.WriteLine(developerInList.DeveloperName + " : " +
            //                          developerInList.DeveloperID + " : " +
            //                          developerInList.CountryCode);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Developer were found.");
            //}

            #endregion

            #endregion

            // Tests Completed.
            #region "VIDEOGAME TESTS"

            #region "UPDATE VIDEOGAME TEST"

            //VideoGame videoGame = new VideoGame();
            //videoGame.GameID = 1;
            //videoGame.Title = "New Videogame title";
            //videoGame.ReleaseDate = Convert.ToDateTime("May 29, 2019");
            //videoGame.TotalHoursPlayed = 50;
            //videoGame.NumberOfAchievemnets = 33;
            //videoGame.DeveloperID = 2;
            //videoGame.GenreID = 1;

            //int rowsAffected = VideoGameManager.UpdateVideoGame(videoGame);
            //Console.WriteLine("Update complete: {0} row(s) affected", rowsAffected);

            #endregion

            #region "DELETE VIDEOGAME TEST"

            //int rows = VideoGameManager.DeleteVideoGame(3);
            //Console.WriteLine(rows);

            #endregion

            #region "INSERT NEW VIDEOGAME TEST"

            //VideoGame videoGameInsert = new VideoGame();
            //videoGameInsert.Title = "New title";
            //videoGameInsert.ReleaseDate = Convert.ToDateTime("September 27, 2011");
            //videoGameInsert.NumberOfAchievemnets = 64;
            //videoGameInsert.TotalHoursPlayed = 30;
            //videoGameInsert.DeveloperID = 2;
            //videoGameInsert.GenreID = 3;

            //VideoGame newVideoGame = VideoGameManager.InsertVideoGame(videoGameInsert);
            //Console.WriteLine(string.Format("               Game ID: {0}\n" +
            //                                "                 Title: {1}\n" +
            //                                "           ReleaseDate: {2}\n" +
            //                                "Number of Achievements: {3}\n" +
            //                                "    Total hours played: {4}\n" +
            //                                "          Developer ID: {5}\n" +
            //                                "           Genre ID is: {6}\n",
            //                                newVideoGame.GameID,
            //                                newVideoGame.Title,
            //                                newVideoGame.ReleaseDate,
            //                                newVideoGame.NumberOfAchievemnets,
            //                                newVideoGame.TotalHoursPlayed,
            //                                newVideoGame.DeveloperID,
            //                                newVideoGame.GenreID));

            #endregion

            #region "GET ONE VIDEOGAME BY ID TEST"

            //Console.Write("Enter a videoGame ID: ");
            //string gameID = Console.ReadLine();

            //VideoGame gameOne = VideoGameManager.GetVideoGame(int.Parse(gameID));
            //if (gameOne != null)
            //{
            //    Console.WriteLine("----------------------------------------------\n" +
            //                      "                 Title: {0}\n" +
            //                      "          Release Date: {1}\n" +
            //                      "    Total Hours Played: {2}\n" +
            //                      "Number Of Achievemnets: {3}\n" +
            //                      "           DeveloperID: {4}\n" +
            //                      "               GenreID: {5}\n",
            //                      gameOne.Title,
            //                      gameOne.ReleaseDate,
            //                      gameOne.TotalHoursPlayed,
            //                      gameOne.NumberOfAchievemnets,
            //                      gameOne.DeveloperID,
            //                      gameOne.GenreID);
            //}
            //else
            //{
            //    Console.WriteLine("Game ID not found");
            //}

            #endregion

            #region "GET ALL VIDEOGAME TEST"

            //List<VideoGame> videoGames = VideoGameManager.GetVideoGameList();
            //if (videoGames.Count() > 0) 
            //{
            //    foreach (VideoGame gameInList in videoGames)
            //    {
            //        Console.WriteLine("----------------------------------------------\n" +
            //                          "                 Title: {0}\n" +
            //                          "          Release Date: {1}\n" +
            //                          "    Total Hours Played: {2}\n" +
            //                          "Number Of Achievemnets: {3}\n" +
            //                          "           DeveloperID: {4}\n" +
            //                          "               GenreID: {5}\n",
            //                          gameInList.Title,
            //                          gameInList.ReleaseDate,
            //                          gameInList.TotalHoursPlayed,
            //                          gameInList.NumberOfAchievemnets,
            //                          gameInList.DeveloperID,
            //                          gameInList.GenreID);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No VideoGames were found.");
            //}


            #endregion

            #endregion

            Console.WriteLine("");
            Console.Read();
        }
    }
}
