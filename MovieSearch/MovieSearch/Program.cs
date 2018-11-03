using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch
{
    public class MovieTitles
    {
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

        public static string[] getMovieTitles(string s)
        {
            throw new NotImplementedException();
        }
    }
}
