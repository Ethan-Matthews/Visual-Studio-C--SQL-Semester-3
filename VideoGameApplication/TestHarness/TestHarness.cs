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
            #region "GENRE TESTS"

            #region "UPDATE GENRE TEST"

            //Genre genre = new Genre();
            //genre.GenreID = 35;
            //genre.GenreName = "New Genre Name";

            //int rowsAffected = GenreManager.UpdateGenre(genre);
            //Console.WriteLine("Update complete: {0} row(s) affected", rowsAffected);

            #endregion

            #region "DELETE GENRE TEST"

            //int rows = GenreManager.DeleteGenre(35);
            //Console.WriteLine(rows);

            #endregion

            #region "INSERT NEW GENRE TEST"

            //Genre genreInsert = new Genre();
            //genreInsert.GenreName = "New Genre";

            //Genre newGenre = GenreManager.InsertGenre(genreInsert);
            //Console.WriteLine(string.Format("The new Genre Id is {0}", newGenre.GenreName));

            #endregion

            #region "GET ALL GENRES TEST"

            //List<Genre> genres = GenreManager.GetGenreList();
            //foreach (Genre genreInList in genres)
            //{
            //    Console.WriteLine(genreInList.GenreName);
            //}

            #endregion

            #region "GET ONE GENRE BY ID TEST"

            Console.Write("enter a genre id: ");
            string genreID = Console.ReadLine();

            Genre genreOne = GenreManager.GetGenre(int.Parse(genreID));
            if (genreOne != null)
            {
                Console.WriteLine(genreOne.GenreName);
            }
            else
            {
                Console.WriteLine("Genre id not found");
            }

            #endregion

            #endregion

            #region "DEVELOPER COUNTRY TESTS"

            #region "UPDATE DEVELOPERCOUNTRY TEST"

            //DeveloperCountry developerCountry = new DeveloperCountry();
            //developerCountry.CountryCode = "NEW";
            //developerCountry.CountryName = "New Country Name";

            //int rowsAffected = DeveloperCountryManager.UpdateDeveloperCountry(developerCountry);
            //Console.WriteLine("Update complete: {0} row(s) affected", rowsAffected);

            #endregion

            #region "DELETE DEVELOPERCOUNTRY TEST"

            //int rows = DeveloperCountryManager.DeleteDeveloperCountry(2);
            //Console.WriteLine(rows);

            #endregion

            #region "INSERT NEW DEVELOPERCOUNTRY TEST"

            //DeveloperCountry developerCountryInsert = new DeveloperCountry();
            //developerCountryInsert.CountryName = "New Country";

            //DeveloperCountry newDeveloperCountry = DeveloperCountryManager.InsertDeveloperCountry(developerCountryInsert);
            //Console.WriteLine(string.Format("The new developerCountry code is {0}", newDeveloperCountry.CountryCode));

            #endregion

            #region "GET ALL DEVELOPERCOUNTRIES TEST"

            //List<DeveloperCountry> developerCountries = DeveloperCountryManager.GetDeveloperCountryList();
            //foreach (DeveloperCountry countryInList in developerCountries)
            //{
            //    Console.WriteLine(countryInList.CountryName);
            //}

            #endregion

            #region "GET ONE DEVELOPERCOUNTRY BY COUNTRYCODE TEST"

            //Console.Write("Enter a category id: ");
            //string countryCode = Console.ReadLine();

            //DeveloperCountry developerCountryOne = DeveloperCountryManager.GetDeveloperCountry(countryCode);
            //if (developerCountryOne != null)
            //{
            //    Console.WriteLine(developerCountryOne.CountryName);
            //}
            //else
            //{
            //    Console.WriteLine("Country Code not found");
            //}

            #endregion

            #endregion

            #region "DEVELOPER TESTS"

            #region "UPDATE DEVELOPER TEST"

            //Developer developer = new Developer();
            //developer.DeveloperID = 50;
            //developer.DeveloperName = "New Developer Name";

            //int rowsAffected = DeveloperManager.UpdateDeveloper(developer);
            //Console.WriteLine("Update complete: {0} row(s) affected", rowsAffected);

            #endregion

            #region "DELETE DEVELOPER TEST"

            //int rows = DeveloperManager.DeleteDeveloper(50);
            //Console.WriteLine(rows);

            #endregion

            #region "INSERT NEW DEVELOPER TEST"

            //Developer developerInsert = new Developer();
            //developerInsert.DeveloperName = "New Developer";

            //Developer newDeveloper = DeveloperCountryManager.InsertDeveloper(developerInsert);
            //Console.WriteLine(string.Format("The new developer ID is {0}", newDeveloper.DeveloperID));

            #endregion

            #region "GET ALL DEVELOPERS TEST"

            //List<Developer> developers = DeveloperManager.GetDeveloperList();
            //foreach (Developer developerInList in developers)
            //{
            //    Console.WriteLine(developerInList.DeveloperName);
            //}

            #endregion

            #region "GET ONE DEVELOPER BY ID TEST"

            //Console.Write("Enter a category ID: ");
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

            #endregion

            Console.WriteLine("");
            Console.Read();
        }
    }
}
