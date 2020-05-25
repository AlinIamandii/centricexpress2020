using System;
using System.Collections.Generic;
using System.Linq;
using Movies.Business.Model;
using Movies.Data;
using Movies.Data.Entities;

namespace Movies.Business
{
    public class MovieBusiness
    {
        private readonly IMovieRepository _movieRepository;

        public MovieBusiness(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public List<MovieModel> Get()
        {
	        var movies = _movieRepository.Get()
		        .Select(MapToMovieModel)
		        .ToList();

            return movies;
        }

        public MovieModel Get(Guid id)
        {
	        var movie = _movieRepository.Get(id);

	        return MapToMovieModel(movie);
        }

        public void Delete(Guid id)
        {
            _movieRepository.Delete(id);
        }

        public void Add(MovieModel movieModel)
        {
            var movie = new Movie
            {
                Id = movieModel.Id,
                Year = movieModel.Year,
                Title = movieModel.Title,
                Rating = movieModel.Rating,
                HasWonOscar = movieModel.HasWonOscar
            };
            _movieRepository.Add(movie);
        }

        public void Edit(MovieModel movieModel)
        {
	        var movie = _movieRepository.Get(movieModel.Id);
            movie.Year = movieModel.Year;
            movie.Title = movieModel.Title;
            movie.Rating = movieModel.Rating;
            movie.HasWonOscar = movieModel.HasWonOscar;

            _movieRepository.Edit(movie);
        }

        public bool Exists(Guid id)
        {
	        return _movieRepository.Exists(id);
        }

        private MovieModel MapToMovieModel(Movie movie)
        {
	        return new MovieModel
	        {
		        Id = movie.Id,
		        Title = movie.Title,
		        Rating = movie.Rating,
		        HasWonOscar = movie.HasWonOscar,
		        Year = movie.Year,
		        Characters = movie.Characters.Select(c =>
			        new CharacterModel
			        {
				        Name = c.Name
			        }).ToList()
	        };
        }
    }
}