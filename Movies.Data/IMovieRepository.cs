using System;
using System.Collections.Generic;
using Movies.Data.Entities;

namespace Movies.Data
{
	public interface IMovieRepository
	{
		IEnumerable<Movie> Get();

		Movie Get(Guid id);

		void Add(Movie entity);

		void Delete(Guid id);

		void Edit(Movie entity);

		bool Exists(Guid id);
	}
}