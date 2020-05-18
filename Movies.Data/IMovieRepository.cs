using System.Collections.Generic;
using Movies.Data.Entities;

namespace Movies.Data
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Get();
        void Add(Movie entity);
    }
}