using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
//Please do not add any additional Libraries here

namespace MovieSearch
{
    public class MovieTitles
    {

        /*
        * Complete the code below to retrieve Movie Title data from the omdbapi web service.
        * You should aim to satisfy each of the 4 Unit tests in the included Tests project within the 90 minutes.
        * You can also run the Console Application manually to debug/test your code if you wish.
        *
        * 1. The Array of Movie Titles should be returned in Alphabetical Order [A-Z]
        * 2. Duplicate Movie Titles should be removed
        * 3. If more than 10 Movie Titles match the Search term you will need to make additional API calls for the additional pages of results
        *           
        * Example URL: https://www.omdbapi.com/?apikey=a31bd40b&s=spiderman&page=1
        *
        * URL PARAMETERS
        *    
        *     api-key   =   Authorization token, must be provided in all requests
        *     s         =   Movie Title to Search For
        *     page      =   Page number of results
        *    
        * An example of the json response from omdbapi is included in the VS Project (ExampleResponse.json)
        */

        public static string[] getMovieTitles(string substr)
        {
            throw new NotImplementedException();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Movie Title to Search for: ");

            string searchTerm = Console.ReadLine();

            string[] results = getMovieTitles(searchTerm);

            //Output movie titles list to the Console:
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }

            Console.ReadLine();

        }
    }
}
