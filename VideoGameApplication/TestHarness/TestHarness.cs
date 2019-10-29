using System;
using System.Collections.Generic;
using System.Linq;
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

            #region "INSERT NEW GENRE TEST"

            //Genre genreInsert = new Genre();
            //genreInsert.GenreName = "The Newest Genre";

            //Genre newGenre = GenreManager.InsertGenre(genreInsert);
            //Console.WriteLine(string.Format("The new Genre Name is {0} at ID {1}", newGenre.GenreName, newGenre.GenreID));

            #endregion

            #region "UPDATE GENRE TEST"

            //Genre genre = new Genre();
            //genre.GenreID = 10;
            //genre.GenreName = "Updated";

            //int rowsAffected = GenreManager.UpdateGenre(genre);
            //Console.WriteLine("Update complete: {0} row(s) affected", rowsAffected);

            #endregion

            #region "DELETE GENRE TEST"

            //int rows = GenreManager.DeleteGenre(10);
            //Console.WriteLine("Lines affected: " + rows + "\n");

            #endregion

            #region "GET ONE GENRE BY ID TEST"

            //Console.Write("Enter a Genre ID: ");
            //string genreID = Console.ReadLine();

            //Genre genreOne = GenreManager.GetGenre(int.Parse(genreID));
            //if (genreOne != null)
            //{
            //    Console.WriteLine("\n" + genreOne.GenreName + "\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nGenre ID not found.\n");
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

            // Navigation

            #region "GET GAMES WITH GENRE ID"

            //Genre genre = GenreManager.GetGenre(1);
            //foreach (VideoGame game in genre.videoGame)
            //{
            //    Console.WriteLine("Name: " + game.Title + "    GenreId: " + game.GenreID);
            //}


            #endregion

            #endregion

            // Tests Completed.
            #region "DEVELOPER COUNTRY TESTS"

            #region "INSERT NEW DEVELOPER COUNTRY TEST"

            //DeveloperCountry developerCountryInsert = new DeveloperCountry();
            //developerCountryInsert.CountryCode = "NCC";
            //developerCountryInsert.CountryName = "New Country";

            //DeveloperCountry newDeveloperCountry = DeveloperCountryManager.InsertDeveloperCountry(developerCountryInsert);
            //Console.WriteLine(string.Format("The new developerCountry code is: {0}\n" +
            //                                "The new country name is: {1}\n",
            //                                newDeveloperCountry.CountryCode,
            //                                newDeveloperCountry.CountryName));

            #endregion

            #region "UPDATE DEVELOPER COUNTRY TEST"

            //DeveloperCountry developerCountry = new DeveloperCountry();
            //developerCountry.CountryCode = "USA";
            //developerCountry.CountryName = "Updated Country Name";


            //int rowsAffected = DeveloperCountryManager.UpdateDeveloperCountry(developerCountry);
            //Console.WriteLine("Update complete: {0} row(s) affected.\n", rowsAffected);

            #endregion

            #region "DELETE DEVELOPER COUNTRY TEST"

            //int rows = DeveloperCountryManager.DeleteDeveloperCountry("USA");
            //Console.WriteLine("Lines affected: " + rows + "\n");

            #endregion

            #region "GET ONE DEVELOPER COUNTRY BY COUNTRYCODE TEST"

            //Console.Write("Enter a developer country code (3 letters): ");
            //string countryCode = Console.ReadLine();

            //DeveloperCountry developerCountryOne = DeveloperCountryManager.GetDeveloperCountry(countryCode);
            //if (developerCountryOne != null)
            //{
            //    Console.WriteLine("\n" + developerCountryOne.CountryName + "\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nCountry Code not found.\n");
            //}

            #endregion

            #region "GET ALL DEVELOPER COUNTRIES TEST"

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

            // Navigation

            #region "GET DEVELOPERS WITH DEVELOPER COUNTRY CODE"

            //DeveloperCountry developerCountry = DeveloperCountryManager.GetDeveloperCountry("CAN");
            //foreach (Developer developer in developerCountry.Developer)
            //{
            //    Console.WriteLine("Name: " + developer.DeveloperName + "    CountryCode: " + developer.CountryCode);
            //}

            #endregion

            #endregion

            // Tests Completed.
            #region "DEVELOPER TESTS"

            #region "INSERT NEW DEVELOPER TEST"

            //Developer developerInsert = new Developer();
            //developerInsert.DeveloperName = "New Developer";
            //developerInsert.CountryCode = "CAN";

            //Developer newDeveloper = DeveloperManager.InsertDeveloper(developerInsert);
            //Console.WriteLine(string.Format("         New Developer ID: {0}\n" +
            //                                "       New Developer Name: {1}\n" +
            //                                "New Developer CountryCode: {2}\n",
            //                                newDeveloper.DeveloperID,
            //                                newDeveloper.DeveloperName,
            //                                newDeveloper.CountryCode));

            #endregion

            #region "UPDATE DEVELOPER TEST"

            //Developer developer = new Developer();
            //developer.DeveloperID = 2;
            //developer.DeveloperName = "New Developer Name";
            //developer.CountryCode = "CAN";

            //int rowsAffected = DeveloperManager.UpdateDeveloper(developer);
            //Console.WriteLine("Update complete: {0} row(s) affected\n", rowsAffected);

            #endregion

            #region "DELETE DEVELOPER TEST"

            //int rows = DeveloperManager.DeleteDeveloper(2);
            //Console.WriteLine(rows);

            #endregion

            #region "GET ONE DEVELOPER BY ID TEST"

            //Console.Write("Enter a Developer ID: ");
            //string developerID = Console.ReadLine();

            //Developer developerOne = DeveloperManager.GetDeveloper(int.Parse(developerID));
            //if (developerOne != null)
            //{
            //    Console.WriteLine("\n" + developerOne.DeveloperName + "\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nDeveloper ID not found.\n");
            //}

            #endregion

            #region "GET ALL DEVELOPERS TEST"

            //List<Developer> developers = DeveloperManager.GetDeveloperList();
            //if (developers.Count() > 0)
            //{
            //    foreach (Developer developerInList in developers)
            //    {
            //        Console.WriteLine("DeveloperName: {0}\n" +
            //                          "  DeveloeprID: {1}\n" +
            //                          "  CountryCode: {2}\n",
            //                          developerInList.DeveloperName,
            //                          developerInList.DeveloperID,
            //                          developerInList.CountryCode);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Developer were found.");
            //}

            #endregion

            // Navigation

            #region "GET GAMES WITH DEVELOPER ID"

            //Developer dev = DeveloperManager.GetDeveloper(2);
            //foreach (VideoGame game in dev.videoGame)
            //{
            //    Console.WriteLine("Name: " + game.Title + "    DevID: " + game.DeveloperID);
            //}

            #endregion

            #region "GET NAVIGATION PROPERTIES FROM DEVELOPER"

            //Developer dev = DeveloperManager.GetDeveloper(1);
            //Console.WriteLine(dev.DeveloperName);
            //Console.WriteLine(dev.CountryCode);

            //Console.WriteLine(dev.DeveloperCountry.CountryName);

            #endregion

            #endregion

            // Tests Completed.
            #region "VIDEOGAME TESTS"

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

            //int rows = VideoGameManager.DeleteVideoGame(2);
            //Console.WriteLine("Rows affected: " + rows + "\n");

            #endregion

            #region "GET ONE VIDEOGAME BY ID TEST"

            //Console.Write("Enter a videoGame ID: ");
            //string gameID = Console.ReadLine();

            //VideoGame gameOne = VideoGameManager.GetVideoGame(int.Parse(gameID));
            //if (gameOne != null)
            //{
            //    Console.WriteLine("----------------------------------------------\n" +
            //                      "               Game ID: {0}\n" +
            //                      "                 Title: {1}\n" +
            //                      "          Release Date: {2}\n" +
            //                      "    Total Hours Played: {3}\n" +
            //                      "Number Of Achievemnets: {4}\n" +
            //                      "           DeveloperID: {5}\n" +
            //                      "               GenreID: {6}\n",
            //                      gameOne.GameID,
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
            //                          "               Game ID: {0}\n" +
            //                          "                 Title: {1}\n" +
            //                          "          Release Date: {2}\n" +
            //                          "    Total Hours Played: {3}\n" +
            //                          "Number Of Achievemnets: {4}\n" +
            //                          "           DeveloperID: {5}\n" +
            //                          "               GenreID: {6}\n",
            //                          gameInList.GameID,
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

            // Navigation

            #region "GET NAVIGATION PROPERTIES FROM GAME"

            //VideoGame game = VideoGameManager.GetVideoGame(1);
            //Console.WriteLine(game.Title);

            //Console.WriteLine(game.Genre.GenreName);

            //Console.WriteLine(game.Deveoper.DeveloperName);

            #endregion

            #endregion

            Console.WriteLine("");
            Console.Read();
        }
    }
}
