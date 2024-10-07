using MovieLibrary.Exceptioins;
using MovieLibrary.Exceptions;
using MovieLibrary.Models;
using MovieLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Controller
{
    public class MovieManager
    {
        private static int movieCount = Serializer.DeserializeMovies().Count;
        private static readonly int MaxNumber = 5;
        private static List<Movie> movies = Serializer.DeserializeMovies();

        public void DisplayMovies()
        {


            foreach (var movie in movies)
            {
                Console.WriteLine(movie);

            }
            if (movieCount == 0)

                throw new IsEmptyException("No Movies to Display");


        }

        public void AddNewMovie(double movieId, string movieName, string movieGenre, double movieYear)
        {

            if (movieCount >= 5)
            {
                throw new ListOverflowException("Movies cannot be added as the list is full");


            }
            movies.Add(new Movie(movieId, movieName, movieGenre, movieYear));
            movieCount++;
            Serializer.Serialize(movies);
        }
        public void EditMovie(double movieId, string newMovieName, string newMovieGenre, double newMovieYear)
        {
            var movie = movies.Find(m => m.MovieId == movieId);
            movie.MovieName = newMovieName;
            movie.MovieGenre = newMovieGenre;
            movie.MovieYear = newMovieYear;
            if (movie == null)
            {
                throw new Exception("Id does not exist");

            }


            Serializer.Serialize(movies);
        }
        public Movie FindMovieById(int movieId)
        {

            var movie = movies.Find(m => m.MovieId == movieId);


            if (movie == null)
            {
                throw new FindMovieByIdException("Movie not found. Please check for Correct Id.");

            }
            return movie;
        }
        public Movie FindMovieByName(string movieName)
        {
            var movie = movies.Find(m => m.MovieName.Equals(movieName));
           
            return movie;

        }
        public void RemoveMovieById(double movieId)
        {
            var movie = movies.Find(m => m.MovieId == movieId);
            if (movie != null)
            {
                movies.Remove(movie);
                movieCount--;
            }


           


        }
        public void RemoveMovieBYName(string movieName)
        {
            var movie = movies.Find(m => m.MovieName.Equals(movieName));

            if (movie != null)
            {
                movies.Remove(movie);
                movieCount--;
            }


            if (movie.MovieName != movieName)
                throw new RemoveMovieBYNameException("Removal of Movie");


        }
        public void ClaerAllMovies()
        {
            movies.Clear();
            movieCount = 0;
            Serializer.Serialize(movies);
        }
        public void Exit()
        {
            Serializer.Serialize(movies);
            Environment.Exit(0);
        }
    }
}

