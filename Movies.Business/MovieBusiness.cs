using System.Collections.Generic;
using System.Linq;
using Movies.Business.Model;
using Movies.Data;
using Movies.Data.Entities;

namespace Movies.Business
{
    public class MovieBusiness : IMovieBusiness
    {
        public List<MovieModel> Get()
        {
            var movies = Database.Movies.Select(m => new MovieModel()
            {
                Id = m.Id,
                Title = m.Title,
                Rating = m.Rating,
                HasWonOscar = m.HasWonOscar,
                Year = m.Year
            })
                .ToList();

            return movies;
        }

        public void Add(MovieModel movieModel)
        {
            var movie = new Movie()
            {
                Id = movieModel.Id,
                Year = movieModel.Year,
                Title = movieModel.Title,
                Rating = movieModel.Rating,
                HasWonOscar = movieModel.HasWonOscar
            };
            Database.Movies.Add(movie);
        }
    }
}