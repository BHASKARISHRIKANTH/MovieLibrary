
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Models
{
    public class Movie
    {
        public double MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public double MovieYear { get; set; }

        public Movie(double movieId, string movieName, string movieGenre, double movieYear)
        {
            MovieId = movieId;
            MovieName = movieName;
            MovieGenre = movieGenre;
            MovieYear = movieYear;
        }

        public override string ToString()
        {
            {
                return $"Movie ID : {MovieId} \n" +
                       $"Movie Name : {MovieName} \n" +
                       $"Movie Genre : {MovieGenre} \n" +
                       $"Movie Year : {MovieYear} \n";
            }
        }
    }
}

