using System.Collections.Generic;
using System.Text.Json;

namespace Test11_MovieJSON
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public DateTime Year { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie()
            {

                Id = 1,
                Name = "Movie 1",
                Rating = 3,
                Year = DateTime.Parse("1/1/1998")
            });

            movies.Add(new()
            {
                Id = 2,
                Name = "Movie 2",
                Rating = 3,
                Year = DateTime.Parse("1/1/2006")
            });

            string jsonString = JsonSerializer.Serialize(movies);

            Console.WriteLine(jsonString);
        }
    }
}
