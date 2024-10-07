using MovieLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieLibrary.Services
{
    public class Serializer
    {
        private static string filePath = @"C:\MoviesApp\MovieLibrary.txt";

        public static void Serialize(List<Movie> movies)
        {

            var json = JsonSerializer.Serialize(movies);
            File.WriteAllText(filePath, json);

        }

        public static List<Movie> DeserializeMovies()
        {
            if (!File.Exists(filePath))
            {
                return new List<Movie>();
            }
            var json = File.ReadAllText(filePath);
            var movies = JsonSerializer.Deserialize<List<Movie>>(json);

            return movies ?? new List<Movie>();
        }
    }
}